--
-- Génération d'un entier aléatoire
-- 
CREATE OR REPLACE FUNCTION get_random_int(INTEGER, INTEGER) RETURNS INTEGER AS $$
DECLARE
    start_int ALIAS FOR $1;
    end_int ALIAS FOR $2;
BEGIN
    RETURN trunc(random() * (end_int-start_int) + start_int);
END;
$$ LANGUAGE 'plpgsql';

--
-- Génération d'un réel aléatoire
-- 
CREATE OR REPLACE FUNCTION get_random_float(INTEGER, INTEGER) RETURNS INTEGER AS $$
DECLARE
    start_int ALIAS FOR $1;
    end_int ALIAS FOR $2;
BEGIN
    RETURN (random() * (end_int-start_int) + start_int);
END;
$$ LANGUAGE 'plpgsql';



--
-- Création de n commandes
--

CREATE OR REPLACE FUNCTION create_commandes(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(id_commande) FROM commande;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO commande (id_commande, reference_commande, date_commande, date_demandee, 
	id_type, id_contact, id_etat, id_client, id_personne) 
	VALUES (id, (SELECT libelle_court FROM type_commande WHERE id_type = (SELECT get_random_int(1,3))) || '00' || id, 
		(SELECT NOW() - '1 year'::INTERVAL * ROUND(RANDOM() * 1)),
		(SELECT NOW() + '1 year'::INTERVAL * ROUND(RANDOM() * 1)),
		(SELECT get_random_int(1,3)), -- type de commande
		(SELECT get_random_int(1,4)), -- moyen contact
		(SELECT get_random_int(1,5)), -- état commande
		(SELECT get_random_int(1,18)), -- client
		(SELECT get_random_int(1,4))); -- utilisateur
END LOOP;
END;
$$ LANGUAGE plpgsql;


--
-- Création de n lignes de commande
--

CREATE OR REPLACE FUNCTION create_ligne_commande(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(id_sol) FROM ligne_de_commande;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO ligne_de_commande (id_sol, numero_ligne, quantite, 
	 id_tva, id_produit, id_etat, id_commande) 
	VALUES (id, (SELECT get_random_int(1, 10)), 
		(SELECT get_random_int(1, 1000)),
		(SELECT get_random_int(1,4)), -- tva
		(SELECT get_random_int(1,51)), -- produit
		(SELECT get_random_int(1,5)), -- état sol
		(SELECT get_random_int(1, 201))); -- id commande
END LOOP;
END;
$$ LANGUAGE plpgsql;


--
-- Création de n produits
--

CREATE OR REPLACE FUNCTION create_produits(nombre bigint) RETURNS void AS
$$

DECLARE
id bigint;
i int;

BEGIN
SELECT INTO id max(id_produit) FROM produit;
IF id ISNULL THEN
id:=0;
END IF;
FOR i IN 1..nombre LOOP
id:=id + 1;
INSERT INTO produit (id_produit, conditionnement, prix_cdt, libelle) 
	VALUES (id, (SELECT get_random_int(25,200)), (SELECT get_random_int(1,60)), 'Produit no.' || id);
END LOOP;
END;
$$ LANGUAGE plpgsql;

SELECT create_ligne_commande(600);
--SELECT create_commandes(200);
--SELECT create_produits(50);

