﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Participants
{
	protected virtual int partId
	{
		get;
		set;
	}

	protected virtual string partNom
	{
		get;
		set;
	}

	protected virtual string partPrenom
	{
		get;
		set;
	}

	protected virtual DateTime partAnnee
	{
		get;
		set;
	}

	protected virtual char partSexe
	{
		get;
		set;
	}

	protected virtual string partCourriel
	{
		get;
		set;
	}

	protected virtual string partLicence
	{
		get;
		set;
	}

	public virtual IEnumerable<Sponsors> lesSponsors
	{
		get;
		set;
	}

	public virtual IEnumerable<Resultats> lesResultats
	{
		get;
		set;
	}

	public Participants(string Nom, string Prenom, DateTime AnneeNaissance, char Sexe, string Courriel)
	{
	}

	public Participants(string Nom, string Prenom, DateTime AnneeNaissance, char Sexe, string Courriel, string Licence)
	{
	}

	public virtual void AddSponsors(Sponsors nomSponsor)
	{
		throw new System.NotImplementedException();
	}

	public virtual void RemoveSponsors(Sponsors nomSponsor)
	{
		throw new System.NotImplementedException();
	}

}

