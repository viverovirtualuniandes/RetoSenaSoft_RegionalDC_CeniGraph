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

        // Aseg�rate de que el MusicManager est� desactivado al inicio
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
            // Teleporta al jugador a la posici�n de destino
            player.transform.position = teleportDestination.position;
            
            // Opcional: ajusta la rotaci�n del jugador si es necesario
            player.transform.rotation = teleportDestination.rotation;
            
            // Activa el MusicManager despu�s del teletransporte
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
            
            // Obt�n el componente AudioSource y aseg�rate de que est� en loop
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