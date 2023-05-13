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
		public RectTransform[] talkPanel;
		public bool isTalking;
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
			isTalking=false;
			
			//talkPanel.gameObject.SetActive(false);
			for (int i = 0; i < talkPanel.Length; i++)
			{
				talkPanel[i].gameObject.SetActive(false);
			}

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
			switch (  npcNameText.text){
				case "月":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="月Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;
					
				case "薛楚":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="薛楚Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;
				
				case "小雅":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="小雅Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;

				case "阿七":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="阿七Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;

				case "周成":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="周成Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;

				case "孟璐":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="孟璐Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;

				case "苏英雄":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="苏英雄Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;

				case "滑头空":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="滑头空Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;

				case "沈厉枭":
				foreach (RectTransform panel in talkPanel)
				{
					if (panel != null && panel.gameObject != null&&panel.gameObject.name=="沈厉枭Chat")
					{
						panel.gameObject.SetActive(panel.gameObject.activeSelf == false);
						isTalking=panel.gameObject.activeSelf;
						
					}
					
				}
				break;
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
