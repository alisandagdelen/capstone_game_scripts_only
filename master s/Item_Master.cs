﻿using UnityEngine;
using System.Collections;

namespace alisanCapstone
{
	public class Item_Master : MonoBehaviour {

        private Player_Master playerMaster;

        public delegate void GeneralEventHandler();
        public event GeneralEventHandler EventObjectThrow;
        public event GeneralEventHandler EventObjectPickup;

        public delegate void PickupActionEventHandler(Transform item);
        public event PickupActionEventHandler EventPickupAction;

		void OnEnable()
		{
            
		}

        void Start()
        {
            SetInitialReferences();
        }

        public void CallEventObjectThrow()
        {
            if (EventObjectThrow != null)
            {
                EventObjectThrow();
                
            }
            playerMaster.CallEventHandsEmpty();
            playerMaster.CallEventInventoryChanged();
        }

        public void CallEventObjectPickup()
        {
            if (EventObjectPickup != null)
            {
                EventObjectPickup();
               
            }
            playerMaster.CallEventInventoryChanged();
        }

        public void CallEvenPickupAction(Transform item)
        {
            if (EventPickupAction != null)
            {
                EventPickupAction(item);
            }
        }

		void SetInitialReferences()
		{
            if (GameManager_References._player != null)
            {
                playerMaster = GameManager_References._player.GetComponent<Player_Master>();
            }
		}
	}
}


