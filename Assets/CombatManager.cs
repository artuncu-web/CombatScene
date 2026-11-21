using JetBrains.Annotations;
using TMPro;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public TextMeshProUGUI enemyHealthBar;
    public Animator player;
    public int enemyHealth = 100;
    public Animator enemy;
    public GameObject gameOverPanel;
    public ParticleSystem attack1;
    public ParticleSystem attack2;

    public void Attack1()
    {

        player.SetTrigger("Attack1");
        enemy.SetTrigger("Hurt");
        attack1.Play();

        enemyHealth -= 10;
        enemyHealthBar.text = " Enemy Health: " + enemyHealth;

        if (enemyHealth <= 0)
        {
            enemy.SetTrigger("Death");
            gameOverPanel.SetActive(true);
        }
     }
    public void Attack2 ()
    {
        player.SetTrigger("Attack2");
        enemy.SetTrigger("Hurt");
        attack2.Play();

        enemyHealth -= 20;
        enemyHealthBar.text = " Enemy Health: " + enemyHealth;
        if (enemyHealth <= 0)
        {
            enemy.SetTrigger("Death");
            gameOverPanel.SetActive(true);

        }

      }
    }