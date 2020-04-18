﻿using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
	[TestClass]
	public class SentimentManagementTest
	{

		SentimentManagement manegement; 

		[TestInitialize]
		public void SetUp()
		{
			manegement = new SentimentManagement(); 
		}


		[TestMethod]
		public void AddValidSentimentPositive1()
		{
			Sentiment sentiment = new Sentiment("I like it", "Positivo");

			
		
			manegement.AddSentiment(sentiment);

			Assert.IsFalse(manegement.IsEmpty()); 

		}

		[TestMethod]
		public void AddValidSentimentPositive2()
		{

			Sentiment sentiment = new Sentiment("Love", "Positivo");

			

			manegement.AddSentiment(sentiment);

			Assert.IsFalse(manegement.IsEmpty());
		}


		[ExpectedException(typeof(TextManagementException))]
		[TestMethod]
		public void VerifySentimentContained1()
		{
			Sentiment sentiment = new Sentiment("Me     gusta", "Positivo");
			
			manegement.AddSentiment(sentiment);

			Sentiment sentiment2 = new Sentiment("No       me         gusta", "Negativo");
			manegement.AddSentiment(sentiment2); 

		}

		[ExpectedException(typeof(TextManagementException))]
		[TestMethod]
		public void VerifySentimentContained2()
		{
			Sentiment sentiment = new Sentiment("No                                me                                              gusta", "Negativo");
			
			manegement.AddSentiment(sentiment);

			Sentiment sentiment2 = new Sentiment("Me            gusta", "Positivo");
			
			manegement.AddSentiment(sentiment2);

		}


		[TestMethod]
		public void VerifySentimentNotContained1()
		{
			Sentiment sentiment = new Sentiment("Me gusta", "Positivo");
			
			manegement.AddSentiment(sentiment);

			Sentiment sentiment2 = new Sentiment("Me encanta", "Positivo");
			
			manegement.AddSentiment(sentiment2);

			Assert.IsTrue(manegement.SentimentList.Count == 2); 
		}


		[TestMethod]
		public void VerifySentimentNotContained2()
		{
			Sentiment sentiment = new Sentiment("Me        gusta mucho                ","Positivo");
			
			manegement.AddSentiment(sentiment);

			Sentiment sentiment2 = new Sentiment("                     Me encanta                            ", "Positivo");
			
			manegement.AddSentiment(sentiment2);

			Assert.AreEqual("Me gusta mucho", manegement.SentimentList[0].SentimientText); 
		}


		[ExpectedException(typeof(ArgumentNullException))]
		[TestMethod]
		public void NotAddInvalidadSentimentPositive1()
		{
			Sentiment sentiment = new Sentiment("                               ", "Neutro");
			manegement.AddSentiment(sentiment); 
		}


		
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void NotAddInvalidSentimentPositive2()
		{
			Sentiment sentiment = new Sentiment("", "Neutro");
			
			manegement.AddSentiment(sentiment); 

		}

		[TestMethod]
		public void DeleteSentimentPositive()
		{
			Sentiment sentiment = new Sentiment("Me gusta", "Positivo");
			manegement.AddSentiment(sentiment);
			manegement.DeleteText(sentiment);
			Assert.IsTrue(manegement.IsEmpty()); 
		}



		[TestMethod]
		public void DeleteThreeSentimentPositive1()
		{
			Sentiment sentiment = new Sentiment("Me gusta","Positivo");
			Sentiment sentiment2 = new Sentiment("Me encanta", "Positivo");
			Sentiment sentiment3 = new Sentiment("Lo amo", "Positivo");
			Sentiment sentiment4 = new Sentiment("Es precioso", "Positivo");
			manegement.AddSentiment(sentiment);
			manegement.AddSentiment(sentiment2);
			manegement.AddSentiment(sentiment3);
			manegement.AddSentiment(sentiment4);
			manegement.DeleteText(sentiment2);
			manegement.DeleteText(sentiment3);
			manegement.DeleteText(sentiment);

			Assert.AreEqual("Es precioso", manegement.SentimentList[0].SentimientText); 
		}


		[TestMethod]
		public void DeleteThreeSentimentPositive2()
		{
			Sentiment sentiment = new Sentiment("Me gusta", "Positivo");
			Sentiment sentiment2 = new Sentiment("Me encanta", "Positivo");
			Sentiment sentiment3 = new Sentiment("Lo amo", "Positivo");
			Sentiment sentiment4 = new Sentiment("Es precioso", "Positivo");
			manegement.AddSentiment(sentiment);
			manegement.AddSentiment(sentiment2);
			manegement.AddSentiment(sentiment3);
			manegement.AddSentiment(sentiment4);
			manegement.DeleteText(sentiment2);
			manegement.DeleteText(sentiment3);
			manegement.DeleteText(sentiment4);

			Assert.AreEqual("Me gusta", manegement.SentimentList[0].SentimientText);
		}

		
		[TestMethod]
		[ExpectedException(typeof(TextManagementException))]
		public void DeleteNotExistSentiment()
		{
			Sentiment sentiment = new Sentiment("Me gusta", "Positivo");
			manegement.AddSentiment(sentiment);
			manegement.DeleteText(sentiment);
			manegement.DeleteText(sentiment); 
		}


		[TestMethod]
		[ExpectedException(typeof(TextManagementException))]
		public void DeleteNotExistSentiment2()
		{
			Sentiment sentiment = new Sentiment("Me gusta", "Positivo");
			manegement.AddSentiment(sentiment);
			Sentiment sentiment2 = new Sentiment("Me encanta", "Positivo");
			manegement.AddSentiment(sentiment2); 
			manegement.DeleteText(sentiment);
			manegement.DeleteText(sentiment2);
			manegement.DeleteText(sentiment2); 
			
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void TryingDeleteEmptySentiment()
		{
			Sentiment sentiment = new Sentiment("", "Positivo");
			manegement.AddSentiment(sentiment);
			manegement.DeleteText(sentiment);
			Sentiment sentiment2 = new Sentiment("Me encanta", "Positivo");
			manegement.AddSentiment(sentiment2);
			manegement.DeleteText(sentiment2);

		}

        [TestMethod]
        public void AddValidSentimentNegative1()
        {
            Sentiment sentiment = new Sentiment("Lo odio", "Negativo");
            manegement.AddSentiment(sentiment);
            Assert.IsFalse(manegement.IsEmpty());
        }

        [TestMethod]
        public void AddValidSentimentNegative2()
        {
            Sentiment sentiment = new Sentiment("Detesto", "Negativo");
            manegement.AddSentiment(sentiment);
            Assert.IsFalse(manegement.IsEmpty());
        }

        [ExpectedException(typeof(TextManagementException))]
        [TestMethod]
        public void VerifyNegativeSentimentContained1()
        {
            Sentiment sentiment = new Sentiment("No     me gusta", "Negativo");
            manegement.AddSentiment(sentiment);
            Sentiment sentiment2 = new Sentiment("No me gusta para nada", "Negativo");
            manegement.AddSentiment(sentiment2);
        }

        [ExpectedException(typeof(TextManagementException))]
        [TestMethod]
        public void VerifyNegativeSentimentContained2()
        {
            Sentiment sentiment = new Sentiment("No me gusta en absoluto", "Negativo");
            manegement.AddSentiment(sentiment);
            Sentiment sentiment2 = new Sentiment("NO   ME GUSTA", "Negativo");
            manegement.AddSentiment(sentiment2);
        }

        [TestMethod]
        public void VerifyNegativeSentimentNotContained1()
        {
            Sentiment sentiment = new Sentiment("Lo odio", "Negativo");
            manegement.AddSentiment(sentiment);
            Sentiment sentiment2 = new Sentiment("Lo detesto", "Negativo");
            manegement.AddSentiment(sentiment2);
            Assert.IsTrue(manegement.SentimentList.Count == 2);
        }

        [TestMethod]
        public void VerifyNegativeSentimentNotContained2()
        {
            Sentiment sentiment = new Sentiment("  Lo  odio              ", "Negativo");
            manegement.AddSentiment(sentiment);
            Sentiment sentiment2 = new Sentiment("Yo    odio", "Negativo");
            manegement.AddSentiment(sentiment2);
            Assert.AreEqual("Lo odio", manegement.SentimentList[0].SentimientText);
        }

        [TestMethod]
        public void DeleteNegativeSentiment()
        {
            Sentiment sentiment = new Sentiment("Es nefasto", "Negativo");
            manegement.AddSentiment(sentiment);
            manegement.DeleteText(sentiment);
            Assert.IsTrue(manegement.IsEmpty());
        }

        [TestMethod]
        public void DeleteThreeNegativesSentiments1()
        {
            Sentiment sentiment = new Sentiment("Lo odio", "Negativo");
            Sentiment sentiment2 = new Sentiment("Lo detesto", "Negativo");
            Sentiment sentiment3 = new Sentiment("Es nefasto", "Negativo");
            Sentiment sentiment4 = new Sentiment("De lo peor", "Negativo");
            manegement.AddSentiment(sentiment);
            manegement.AddSentiment(sentiment2);
            manegement.AddSentiment(sentiment3);
            manegement.AddSentiment(sentiment4);
            manegement.DeleteText(sentiment2);
            manegement.DeleteText(sentiment3);
            manegement.DeleteText(sentiment);
            Assert.AreEqual("De lo peor", manegement.SentimentList[0].SentimientText);
        }

        [TestMethod]
        public void DeleteThreeNegativesSentiments2()
        {
            Sentiment sentiment = new Sentiment("Lo odio", "Negativo");
            Sentiment sentiment2 = new Sentiment("Lo detesto", "Negativo");
            Sentiment sentiment3 = new Sentiment("Es nefasto", "Negativo");
            Sentiment sentiment4 = new Sentiment("De lo peor", "Negativo");
            manegement.AddSentiment(sentiment);
            manegement.AddSentiment(sentiment2);
            manegement.AddSentiment(sentiment3);
            manegement.AddSentiment(sentiment4);
            manegement.DeleteText(sentiment2);
            manegement.DeleteText(sentiment3);
            manegement.DeleteText(sentiment4);
            Assert.AreEqual("Lo odio", manegement.SentimentList[0].SentimientText);
        }

        [TestMethod]
        [ExpectedException(typeof(TextManagementException))]
        public void DeleteNotExistNegativeSentiment()
        {
            Sentiment sentiment = new Sentiment("Lo odio", "Negativo");
            manegement.AddSentiment(sentiment);
            manegement.DeleteText(sentiment);
            manegement.DeleteText(sentiment);
        }


		[TestMethod]
		[ExpectedException(typeof(TextManagementException))]
		public void TryingAddInvalidSentiment()
		{
			Sentiment sentiment = new Sentiment("Posible", "Positivo");
			manegement.AddSentiment(sentiment);
			Sentiment sentiment2 = new Sentiment("Imposible", "Negativo");
			manegement.AddSentiment(sentiment2); 
		}

		[TestMethod]
		[ExpectedException(typeof(TextManagementException))]
		public void TryingAddInvalidSentiment2()
		{
			Sentiment sentiment = new Sentiment("Imposible", "Negativo");
			manegement.AddSentiment(sentiment);
			Sentiment sentiment2 = new Sentiment("Posible", "Positivo");
			manegement.AddSentiment(sentiment2);
		}


		[TestMethod]
		[ExpectedException(typeof(TextManagementException))]
		public void TryingAddRepeteadSentiment()
		{
			Sentiment sentiment = new Sentiment("Posible", "Positivo");
			manegement.AddSentiment(sentiment);
			Sentiment sentiment2 = new Sentiment("Posible", "Positivo");
			manegement.AddSentiment(sentiment2);
		}







	}
}