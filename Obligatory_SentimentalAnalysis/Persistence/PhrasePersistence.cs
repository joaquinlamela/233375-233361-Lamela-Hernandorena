﻿using BusinessLogicExceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class PhrasePersistence
    {
        public PhrasePersistence()
        {

        }

        public void AddPhrase(Phrase phrase)
        {
            using (Context ctx = new Context())
            {
                try
                {
                    ctx.Phrases.Add(phrase);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new PhraseManagementException("Error agregando frase", ex);
                }
            }
        }

        public bool IsEmpty()
        {
            using (Context ctx = new Context())
            {
                return ctx.Phrases.Count() == 0;
            }
        }

        public void DeletePhrasesOfAuthor(Author author)
        {
            using (Context ctx = new Context())
            {
                try
                {
                    List<Phrase> authorPhrases = ctx.Phrases.Where(p => p.PhraseAuthor.Id == author.Id).ToList();
                    foreach (Phrase phrase in authorPhrases)
                    {
                        phrase.IsDeleted = true;
                    }
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new PhraseManagementException("Error eliminado frases", ex);
                }
            }
        }
        public Phrase[] AllPhrases()
        {
            using (Context ctx = new Context())
            {
                return ctx.Phrases.Where(p => !p.IsDeleted).ToArray();
            }
        }
    }
}

    

