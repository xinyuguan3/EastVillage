using UnityEngine;
using System.Collections;


namespace PixelCrushers.LoveHate.Example
{

	/// <summary>
	/// This script maintains the faction info window in the lower
	/// right of the example scene.
	/// </summary>
	public class InteractionUI : MonoBehaviour 
	{

		public CanvasGroup introCanvasGroup;

		public RectTransform interactionPanel;
		public RectTransform infoPanel;
		public RectTransform talkPanel;
		public RectTransform bagPanel;
		public GameObject[] chatScript;

		public UnityEngine.UI.Text npcSummaryText;
		public UnityEngine.UI.Text talkCharacterNameText;
		public UnityEngine.UI.Text npcNameText;

		public UnityEngine.UI.Image npcImg;

		public UnityEngine.UI.Button flatterButton;
		public UnityEngine.UI.Button insultButton;
		public UnityEngine.UI.Button giveButton;
		public UnityEngine.UI.Button stealButton;

		private IEnumerator Start()
		{
			SetInteractionPanel(false);
			
			talkPanel.gameObject.SetActive(false);
			// for (int i = 0; i < talkPanel.Length; i++)
			// {
			// 	SetTalkPanel(false,i);
			// }

			// Wait for intro canvas to close:
			float elapsed = 0;
			while (elapsed < 50)
			{
				if (IsInterruptKeyDown()) break;
				yield return null;
				elapsed += GameTime.deltaTime;
			}
			if (introCanvasGroup != null && introCanvasGroup.gameObject != null)
			{
				while (introCanvasGroup.alpha > 0.05f)
				{
					if (IsInterruptKeyDown()) break;
					yield return null;
					introCanvasGroup.alpha -= GameTime.deltaTime;
				}
				introCanvasGroup.gameObject.SetActive(false);
			}
		}

		private bool IsInterruptKeyDown()
		{
			return Input.GetKeyDown(KeyCode.Escape) ||
					Input.GetKeyDown(KeyCode.Return) ||
					Input.GetKeyDown(KeyCode.Space) ||
					Input.GetMouseButtonDown(0) ||
					Mathf.Abs(Input.GetAxis("Vertical")) > 0.1 ||
					Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1;
		}

		public void SetInteractionPanel(bool value)
		{
			if (interactionPanel != null && interactionPanel.gameObject != null)
			{
				interactionPanel.gameObject.SetActive(value);
			}
		}

		public void SetInfoPanel()
		{
			if (infoPanel != null && infoPanel.gameObject != null)
			{
				infoPanel.gameObject.SetActive(infoPanel.gameObject.activeSelf == false);
			}
		}

		public void SetTalkPanel()
		{
			if (talkPanel != null && talkPanel.gameObject != null)
			{
				talkPanel.gameObject.SetActive(talkPanel.gameObject.activeSelf == false);

				
			}
		}

		// public void SetTalkPanel(bool value)
		// {
		// 	foreach (var p in chatScript)
		// 	{
		// 		//Debug.Log(p.name+","+npcNameText.text);
		// 		if(p.name==npcNameText.text){
					
		// 				talkPanel.gameObject.SetActive(value);
		// 			//Debug.Log(p.activeSelf);
		// 		}
		// 	}
			
		// }

		public void SetBagPanel()
		{
			if (bagPanel != null && bagPanel.gameObject != null)
			{
				bagPanel.gameObject.SetActive(bagPanel.gameObject.activeSelf == false);
			}
			
		}

		//public void SetDeedButtons(bool value)
		//{
		//	if (flatterButton != null) flatterButton.gameObject.SetActive(value);
		//	if (insultButton != null) insultButton.gameObject.SetActive(value);
		//	if (giveButton != null) giveButton.gameObject.SetActive(value);
		//	if (stealButton != null) stealButton.gameObject.SetActive(value);
		//}
		
	}

}
