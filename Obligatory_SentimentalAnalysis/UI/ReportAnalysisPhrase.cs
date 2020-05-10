﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using BusinessLogicExceptions; 

namespace UI
{
	public partial class ReportAnalysisPhrase : UserControl
	{
		private GeneralManagement generalManagement; 
		public ReportAnalysisPhrase(GeneralManagement general)
		{
			InitializeComponent();
			generalManagement = general;
			InitializeGridOfPhrases();
			ChangeNameOfColumnGrid(); 
		}



		private void InitializeGridOfPhrases()
		{
			grdPhrases.DataSource = generalManagement.PhraseManagement.AllPhrases; 
		}


		private void ChangeNameOfColumnGrid()
		{
			for (int i = 0; i < grdPhrases.Columns.Count; i++)
			{

				string str = grdPhrases.Columns[i].HeaderText;
				if (str == "TextPhrase")
				{
					grdPhrases.Columns[i].HeaderText = "Texto de la frase";
					grdPhrases.Columns[i].Name = "Texto de la frase";
				}

				if (str == "PhraseDate")
				{
					grdPhrases.Columns[i].HeaderText = "Fecha de la frase";
					grdPhrases.Columns[i].Name = "Fecha de la frase";

				}

				if (str == "Entity")
				{
					grdPhrases.Columns[i].HeaderText = "Entidad";
				    grdPhrases.Columns[i].Name = "Entidad";
				}

				if (str == "TypePhrase")
				{
					grdPhrases.Columns[i].HeaderText = "Tipo de frase";
					grdPhrases.Columns[i].Name = "Tipo de frase";
				}
				
			}
		}


	}
}
