using System;
using Microsoft.VisualBasic.CompilerServices;

namespace Simple_Bot
{
	public partial class _ClientBot
	{
		// Opcode table (packet[4]): 0=login-failure, 1=login-flow, 2=chat, 3=self/player-info,
		// 4=other-player-info, 5=character-stats, 6=(unused), 8=battle-stat-delta, 9=battle-ack,
		// 11=battle-roster, 12=map-arrival, 13=party-event, 15=pet-list/horse, 16=btq-quiz-prompt,
		// 19=pet-battle-select, 20=quest-dialog-state, 22=npc-map-update, 23=inventory-update,
		// 24=quest-progress, 25=item-trade-result, 26=gold-update, 36=captcha-challenge,
		// 50=battle-skill-effect, 52=battle-turn-advance, 53=login-success/battle-slot-clear,
		// 65=mini-game-toggle, 78=astrolabe-bonus.
		private void DispatchPacket(byte[] packet)
		{
			try
			{
				switch (packet[4])
				{
				case 0:
					HandleLoginFailure(packet);
					break;
				case 1:
					HandleLoginFlow(packet);
					break;
				case 2:
					HandleChatMessage(packet);
					break;
				case 3:
					HandleSelfOrPlayerInfo(packet);
					break;
				case 4:
					HandleOtherPlayerInfo(packet);
					break;
				case 5:
					HandleCharacterStats(packet);
					break;
				case 6:
					HandleUnusedOpcode6(packet);
					break;
				case 8:
					HandleBattleStatDelta(packet);
					break;
				case 9:
					HandleBattleAck(packet);
					break;
				case 11:
					HandleBattleRoster(packet);
					break;
				case 12:
					HandleMapArrival(packet);
					break;
				case 13:
					HandlePartyEvent(packet);
					break;
				case 15:
					HandlePetListAndHorse(packet);
					break;
				case 16:
					HandleBtqQuizPrompt(packet);
					break;
				case 19:
					HandlePetBattleSelect(packet);
					break;
				case 20:
					HandleQuestDialogState(packet);
					break;
				case 22:
					HandleNpcMapUpdate(packet);
					break;
				case 23:
					HandleInventoryUpdate(packet);
					break;
				case 24:
					HandleQuestProgress(packet);
					break;
				case 25:
					HandleItemTradeResult(packet);
					break;
				case 26:
					HandleGoldUpdate(packet);
					break;
				case 36:
					HandleCaptchaChallenge(packet);
					break;
				case 50:
					HandleBattleSkillEffect(packet);
					break;
				case 52:
					HandleBattleTurnAdvance(packet);
					break;
				case 53:
					HandleLoginSuccessOrBattleSlotClear(packet);
					break;
				case 65:
					HandleMiniGameToggle(packet);
					break;
				case 78:
					HandleAstrolabeBonus(packet);
					break;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}
}
