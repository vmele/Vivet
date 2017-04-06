--
-- Génération d'un nombre aléatoire
-- 
CREATE OR REPLACE FUNCTION get_random_number(INTEGER, INTEGER) RETURNS INTEGER AS $$
DECLARE
    start_int ALIAS FOR $1;
    end_int ALIAS FOR $2;
BEGIN
    RETURN trunc(random() * (end_int-start_int) + start_int);
END;
$$ LANGUAGE 'plpgsql';


create function date_rand ( @fromDate date, @toDate date) returns date
as
begin

 declare @days_between int
 declare @days_rand int

 set @days_between = datediff(day,@fromDate,@toDate)
 set @days_rand  = cast(RAND()*10000 as int)  % @days_between

 return dateadd( day, @days_rand, @fromDate )
end;

--
-- Création de n exploitants
--

CREATE OR REPLACE FUNCTION create_exploitant(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(code_exploitant) FROM exploitant;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO exploitant (code_exploitant, adresse_exploitant) VALUES (id, 'Adresse n°' || i);
END LOOP;
END;
$$ LANGUAGE plpgsql;


--
-- Création de n zones
--

CREATE OR REPLACE FUNCTION create_zone(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(code_zone) FROM zone;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO zone (code_zone) VALUES (id);
END LOOP;
END;
$$ LANGUAGE plpgsql;



--
-- Création de n etablissements
--

CREATE OR REPLACE FUNCTION create_etablissement(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(code_etab) FROM etablissement;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO etablissement (code_etab, appellation_etab, adresse_etab, code_zone) 
	VALUES (id, 'Appellation n°' || i, 'Adresse n°' || i, (SELECT get_random_number(1, 100)));
END LOOP;
END;
$$ LANGUAGE plpgsql;


--
-- Suppression de n etablissements
--

CREATE OR REPLACE FUNCTION delete_etablissement() RETURNS void AS
$$

BEGIN
DELETE FROM etablissement;
END;
$$ LANGUAGE plpgsql;



--
-- Création de n type de terrasses
--

CREATE OR REPLACE FUNCTION create_type_terrasse(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(code_type_terrasse) FROM type_terrasse;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO type_terrasse (code_type_terrasse, libelle_type_terrasse, date_ouverture, date_fermeture) 
	VALUES (id, 'Libelle n°' || i, '2016-05-21', '2016-05-29');
END LOOP;
END;
$$ LANGUAGE plpgsql;



--
-- Création de n terrasses
--

CREATE OR REPLACE FUNCTION create_terrasse(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(no_sequentiel) FROM terrasse;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO terrasse (no_sequentiel, surface, date_installation, code_etab, code_type_terrasse) 
	VALUES (id, (SELECT get_random_number(9, 24)), '2016-10-18', (SELECT get_random_number(1, 400)), (SELECT get_random_number(1, 4)) );
END LOOP;
END;
$$ LANGUAGE plpgsql;


--
-- Suppression des terrasses
--

CREATE OR REPLACE FUNCTION delete_terrasse() RETURNS void AS
$$

BEGIN
DELETE FROM terrasse;
END;
$$ LANGUAGE plpgsql;



--
-- Création des exploitatations
--

CREATE OR REPLACE FUNCTION create_exploitation(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
id:=0;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO exploitation (date_debut_exp, date_fin_exp, code_etab, code_exploitant) 
	VALUES ('2016-04-28', '2016-05-30', id, (SELECT get_random_number(1, 501)));
END LOOP;
END;
$$ LANGUAGE plpgsql;






CREATE OR REPLACE FUNCTION function_physique() RETURNS trigger AS $emp_stamp$
    BEGIN
    
        IF EXISTS(SELECT personne_physique.code_exploitant FROM personne_physique, personne_morale WHERE personne_physique.code_exploitant = personne_morale.code_exploitant) THEN
		RAISE EXCEPTION 'Cet exploitant existe déja.';
	END IF;
	RETURN NULL;
    END;
    
$emp_stamp$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_personne_physique BEFORE INSERT OR UPDATE ON personne_physique
   FOR EACH ROW EXECUTE PROCEDURE function_physique();
