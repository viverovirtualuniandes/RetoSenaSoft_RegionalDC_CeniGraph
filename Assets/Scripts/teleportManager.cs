using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class VRTeleporter : MonoBehaviour
{
    public Button teleportButton;
    public Transform teleportDestination;
    public GameObject player;
    public GameObject musicManager; // Referencia al GameObject MusicManager

    private void Start()
    {
        if (teleportButton != null)
        {
            teleportButton.onClick.AddListener(TeleportPlayer);
        }
        else
        {
            Debug.LogError("Teleport button is not assigned!");
        }

        // Asegúrate de que el MusicManager esté desactivado al inicio
        if (musicManager != null)
        {
            musicManager.SetActive(false);
        }
        else
        {
            Debug.LogError("MusicManager is not assigned!");
        }
    }

    private void TeleportPlayer()
    {
        if (teleportDestination != null && player != null)
        {
            // Teleporta al jugador a la posición de destino
            player.transform.position = teleportDestination.position;
            
            // Opcional: ajusta la rotación del jugador si es necesario
            player.transform.rotation = teleportDestination.rotation;
            
            // Activa el MusicManager después del teletransporte
            ActivateMusicManager();
            
            Debug.Log("Player teleported to destination and music activated!");
        }
        else
        {
            Debug.LogError("Teleport destination or player is not assigned!");
        }
    }

    private void ActivateMusicManager()
    {
        if (musicManager != null)
        {
            musicManager.SetActive(true);
            
            // Obtén el componente AudioSource y asegúrate de que esté en loop
            AudioSource audioSource = musicManager.GetComponent<AudioSource>();
            if (audioSource != null)
            {
                audioSource.loop = true;
                audioSource.Play();
            }
            else
            {
                Debug.LogError("AudioSource component not found on MusicManager!");
            }
        }
    }
}