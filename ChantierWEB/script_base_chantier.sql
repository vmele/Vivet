--
-- PostgreSQL database dump
--

-- Dumped from database version 9.5.4
-- Dumped by pg_dump version 9.5.4

-- Started on 2016-10-07 08:16:17

SET statement_timeout = 0;
SET lock_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- TOC entry 1 (class 3079 OID 12355)
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- TOC entry 2121 (class 0 OID 0)
-- Dependencies: 1
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 182 (class 1259 OID 16402)
-- Name: chantier; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE chantier (
    id_chantier integer NOT NULL,
    nom character varying(255),
    date_debut date,
    montant numeric(10,2),
    id_client integer,
    id_user integer
);


ALTER TABLE chantier OWNER TO postgres;

--
-- TOC entry 2122 (class 0 OID 0)
-- Dependencies: 182
-- Name: COLUMN chantier.date_debut; Type: COMMENT; Schema: public; Owner: postgres
--

COMMENT ON COLUMN chantier.date_debut IS '
';


--
-- TOC entry 181 (class 1259 OID 16394)
-- Name: client; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE client (
    id_client integer NOT NULL,
    raison_sociale_client character varying(255),
    telephone character varying(20),
    mail character varying(255)
);


ALTER TABLE client OWNER TO postgres;

--
-- TOC entry 183 (class 1259 OID 16412)
-- Name: users; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE users (
    id_user integer NOT NULL,
    username character varying(255),
    password character varying(255)
);


ALTER TABLE users OWNER TO postgres;

--
-- TOC entry 2112 (class 0 OID 16402)
-- Dependencies: 182
-- Data for Name: chantier; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY chantier (id_chantier, nom, date_debut, montant, id_client, id_user) FROM stdin;
2	Salle infomartique SERAM	2015-12-29	530.48	2	2
5	Locaux METRO	2016-12-23	11700.58	4	3
8	Salle de bain	2016-10-30	3652.21	2	1
9	fefz	2016-10-30	5.50	1	1
\.


--
-- TOC entry 2111 (class 0 OID 16394)
-- Dependencies: 181
-- Data for Name: client; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY client (id_client, raison_sociale_client, telephone, mail) FROM stdin;
1	LOXAM	0645857498	loxam@lox.com
3	CFAI	0477256595	cfai@cite.com
4	METRO	0425986587	metro@metrofrance.fr
2	SERAM	0477350035	seramfr@seram.com
7	Carrefour	04 77 25 77 78	carrouf@carrefour.io
\.


--
-- TOC entry 2113 (class 0 OID 16412)
-- Dependencies: 183
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY users (id_user, username, password) FROM stdin;
1	vmele	vmele
2	gmagnier	gmagnier
3	fvivet	fvivet
\.


--
-- TOC entry 1992 (class 2606 OID 16406)
-- Name: pk_id_chantier; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY chantier
    ADD CONSTRAINT pk_id_chantier PRIMARY KEY (id_chantier);


--
-- TOC entry 1990 (class 2606 OID 16401)
-- Name: pk_id_client; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY client
    ADD CONSTRAINT pk_id_client PRIMARY KEY (id_client);


--
-- TOC entry 1994 (class 2606 OID 16419)
-- Name: pk_user_id; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY users
    ADD CONSTRAINT pk_user_id PRIMARY KEY (id_user);


--
-- TOC entry 1995 (class 2606 OID 16407)
-- Name: fk_id_client; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY chantier
    ADD CONSTRAINT fk_id_client FOREIGN KEY (id_client) REFERENCES client(id_client);


--
-- TOC entry 1996 (class 2606 OID 16420)
-- Name: fk_id_user; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY chantier
    ADD CONSTRAINT fk_id_user FOREIGN KEY (id_user) REFERENCES users(id_user);


--
-- TOC entry 2120 (class 0 OID 0)
-- Dependencies: 6
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2016-10-07 08:16:17

--
-- PostgreSQL database dump complete
--

