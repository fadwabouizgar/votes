using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteByLeapMotionProject
{
  /// <summary>
    ///     ///  this class allow us to create the object Election
    ///  we find here the object Election's setters and getters
  /// </summary>
  class Election
  {
    private String nom;
    private Dictionary<int, Choix> listeChoix;
    private List<Vote> listeVote;

    public Election(String nom)
    {
      this.nom = nom;
      listeChoix = new Dictionary<int, Choix>();
      listeVote = new List<Vote>();
    }
    
    public void setNom(String nom)
    {
      this.nom = nom;
    }

    public String getNom()
    {
      return nom;
    }
    
    public void setListeChoix(Dictionary<int, Choix> listeChoix)
    {
      this.listeChoix = listeChoix;
    }
    
    public Dictionary<int, Choix> getListeChoix()
    {
      return listeChoix;
    }

    public void setListeVote(List<Vote> listeVote)
    {
      this.listeVote = listeVote;
    }

    public List<Vote> getListeVote()
    {
      return listeVote;
    }
  }
}
