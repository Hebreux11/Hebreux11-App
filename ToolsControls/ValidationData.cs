using System;
using System.Configuration;
using Hebreux11AppServer.Models;
using Microsoft.Extensions.Configuration;

namespace Hebreux11AppServer.ToolsControls
{
    public class ValidationData
    {
        public string MessageErreur { get; set; }
        public bool ValidationFormulaire(FormulaireModel data)
        {
            if (string.IsNullOrWhiteSpace(data.NomClient))
            {
                MessageErreur = "Indiquer votre nom";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Sujet))
            {
                MessageErreur = "Indiquer le sujet de votre requete";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.EmailClient))
            {
                MessageErreur = "Indiquer votre email";
                return false;
            }
            else if (!data.EmailClient.Contains('@') && !data.EmailClient.Contains('.'))
            {
                MessageErreur = "Indiquer votre email valide";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.Services))
            {
                MessageErreur = "Choisissez un service";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.MessageClient))
            {
                MessageErreur = "Indiquer votre message en quelque mots";
                return false;
            }
            else
                return true;

        }

        internal bool ValidationEvent(InvitesModel data)
        {
            if (string.IsNullOrWhiteSpace(data.NomInviter))
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.TypeInviter) || data.TypeInviter == "-------Selectionner ici-------")
            {
                return false;
            }
            else if (string.IsNullOrWhiteSpace(data.TableInviter.NomTable) || data.TableInviter.NomTable == "-------Selectionner ici-------")
            {
                return false;
            }
            else
                return true;
        }
    }

}


