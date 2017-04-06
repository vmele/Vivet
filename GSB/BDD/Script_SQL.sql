------------------------------------------------------------
--        Script Postgre 
------------------------------------------------------------



------------------------------------------------------------
-- Table: commande
------------------------------------------------------------
CREATE TABLE public.commande(
	id_commande        INT  NOT NULL ,
	reference_commande VARCHAR (15)  ,
	date_commande      DATE   ,
	date_demandee      DATE   ,
	frais_de_port      BOOL   ,
	id_type            INT  NOT NULL ,
	id_contact         INT  NOT NULL ,
	id_facture         INT  NOT NULL ,
	id_shipment        INT  NOT NULL ,
	id_personne        INT  NOT NULL ,
	id_etat            INT  NOT NULL ,
	CONSTRAINT prk_constraint_commande PRIMARY KEY (id_commande)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: type_commande
------------------------------------------------------------
CREATE TABLE public.type_commande(
	id_type       INT  NOT NULL ,
	libelle       VARCHAR (20)  ,
	libelle_court CHAR (2)   ,
	CONSTRAINT prk_constraint_type_commande PRIMARY KEY (id_type)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: moyen_contact_commande
------------------------------------------------------------
CREATE TABLE public.moyen_contact_commande(
	id_contact INT  NOT NULL ,
	libelle    VARCHAR (25)  ,
	CONSTRAINT prk_constraint_moyen_contact_commande PRIMARY KEY (id_contact)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: etat_so
------------------------------------------------------------
CREATE TABLE public.etat_so(
	id_etat INT  NOT NULL ,
	libelle VARCHAR (25)  ,
	CONSTRAINT prk_constraint_etat_so PRIMARY KEY (id_etat)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: tva
------------------------------------------------------------
CREATE TABLE public.tva(
	id_tva  INT  NOT NULL ,
	taux    INT2   ,
	libelle VARCHAR (25)  ,
	CONSTRAINT prk_constraint_tva PRIMARY KEY (id_tva)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: ligne_de_ commande
------------------------------------------------------------
CREATE TABLE public.ligne_de__commande(
	id_sol       INT  NOT NULL ,
	numero_ligne INT   ,
	quantite     INT   ,
	montant      NUMERIC (10,2)   ,
	id_commande  INT  NOT NULL ,
	id_tva       INT  NOT NULL ,
	id_produit   INT  NOT NULL ,
	id_etat      INT  NOT NULL ,
	CONSTRAINT prk_constraint_ligne_de__commande PRIMARY KEY (id_sol,id_commande)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: shipment
------------------------------------------------------------
CREATE TABLE public.shipment(
	id_shipment        INT  NOT NULL ,
	reference_shipment VARCHAR (25)  ,
	date_envoi         DATE   ,
	id_commande        INT  NOT NULL ,
	CONSTRAINT prk_constraint_shipment PRIMARY KEY (id_shipment)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: facture
------------------------------------------------------------
CREATE TABLE public.facture(
	id_facture  INT  NOT NULL ,
	reference   VARCHAR (25)  ,
	id_commande INT  NOT NULL ,
	CONSTRAINT prk_constraint_facture PRIMARY KEY (id_facture)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: produit
------------------------------------------------------------
CREATE TABLE public.produit(
	id_produit      INT  NOT NULL ,
	conditionnement INT2   ,
	prix_cdt        NUMERIC (6,2)   ,
	CONSTRAINT prk_constraint_produit PRIMARY KEY (id_produit)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: personne
------------------------------------------------------------
CREATE TABLE public.personne(
	id_personne INT  NOT NULL ,
	nom         VARCHAR (25)  ,
	prenom      VARCHAR (25)  ,
	CONSTRAINT prk_constraint_personne PRIMARY KEY (id_personne)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: utilisateur
------------------------------------------------------------
CREATE TABLE public.utilisateur(
	identifiant  VARCHAR (25) NOT NULL ,
	mot_de_passe VARCHAR (25)  ,
	mail         VARCHAR (25)  ,
	id_personne  INT  NOT NULL ,
	id_droit     INT  NOT NULL ,
	CONSTRAINT prk_constraint_utilisateur PRIMARY KEY (id_personne)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: employe
------------------------------------------------------------
CREATE TABLE public.employe(
	id_personne INT  NOT NULL ,
	CONSTRAINT prk_constraint_employe PRIMARY KEY (id_personne)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: droits
------------------------------------------------------------
CREATE TABLE public.droits(
	id_droit INT  NOT NULL ,
	libelle  VARCHAR (25)  ,
	CONSTRAINT prk_constraint_droits PRIMARY KEY (id_droit)
)WITHOUT OIDS;


------------------------------------------------------------
-- Table: etat_sol
------------------------------------------------------------
CREATE TABLE public.etat_sol(
	id_etat INT  NOT NULL ,
	libelle VARCHAR (25)  ,
	CONSTRAINT prk_constraint_etat_sol PRIMARY KEY (id_etat)
)WITHOUT OIDS;



ALTER TABLE public.commande ADD CONSTRAINT FK_commande_id_type FOREIGN KEY (id_type) REFERENCES public.type_commande(id_type);
ALTER TABLE public.commande ADD CONSTRAINT FK_commande_id_contact FOREIGN KEY (id_contact) REFERENCES public.moyen_contact_commande(id_contact);
ALTER TABLE public.commande ADD CONSTRAINT FK_commande_id_facture FOREIGN KEY (id_facture) REFERENCES public.facture(id_facture);
ALTER TABLE public.commande ADD CONSTRAINT FK_commande_id_shipment FOREIGN KEY (id_shipment) REFERENCES public.shipment(id_shipment);
ALTER TABLE public.commande ADD CONSTRAINT FK_commande_id_personne FOREIGN KEY (id_personne) REFERENCES public.personne(id_personne);
ALTER TABLE public.commande ADD CONSTRAINT FK_commande_id_etat FOREIGN KEY (id_etat) REFERENCES public.etat_so(id_etat);
ALTER TABLE public.ligne_de__commande ADD CONSTRAINT FK_ligne_de__commande_id_commande FOREIGN KEY (id_commande) REFERENCES public.commande(id_commande);
ALTER TABLE public.ligne_de__commande ADD CONSTRAINT FK_ligne_de__commande_id_tva FOREIGN KEY (id_tva) REFERENCES public.tva(id_tva);
ALTER TABLE public.ligne_de__commande ADD CONSTRAINT FK_ligne_de__commande_id_produit FOREIGN KEY (id_produit) REFERENCES public.produit(id_produit);
ALTER TABLE public.ligne_de__commande ADD CONSTRAINT FK_ligne_de__commande_id_etat FOREIGN KEY (id_etat) REFERENCES public.etat_sol(id_etat);
ALTER TABLE public.shipment ADD CONSTRAINT FK_shipment_id_commande FOREIGN KEY (id_commande) REFERENCES public.commande(id_commande);
ALTER TABLE public.facture ADD CONSTRAINT FK_facture_id_commande FOREIGN KEY (id_commande) REFERENCES public.commande(id_commande);
ALTER TABLE public.utilisateur ADD CONSTRAINT FK_utilisateur_id_personne FOREIGN KEY (id_personne) REFERENCES public.personne(id_personne);
ALTER TABLE public.utilisateur ADD CONSTRAINT FK_utilisateur_id_droit FOREIGN KEY (id_droit) REFERENCES public.droits(id_droit);
ALTER TABLE public.employe ADD CONSTRAINT FK_employe_id_personne FOREIGN KEY (id_personne) REFERENCES public.personne(id_personne);
