﻿// 
// This file was generated by "KanColleProxy.Endpoints.tt"
// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Fiddler;

namespace Grabacr07.KanColleWrapper
{
	partial class KanColleProxy
	{
		// ReSharper disable InconsistentNaming

		/// <summary>
		/// エンド ポイント "/kcsapi/api_start2" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_start2
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_start2"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_port/port" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_port
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_port/port"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/basic" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_basic
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/basic"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/ship" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_ship
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/ship"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/ship2" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_ship2
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/ship2"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/ship3" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_ship3
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/ship3"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/slot_item" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_slot_item
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/slot_item"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/useitem" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_useitem
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/useitem"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/deck" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_deck
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/deck"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/deck_port" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_deck_port
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/deck_port"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/ndock" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_ndock
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/ndock"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/kdock" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_kdock
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/kdock"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/material" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_material
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/material"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_get_member/questlist" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_get_member_questlist
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_get_member/questlist"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_hensei/change" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_hensei_change
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_hensei/change"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_hokyu/charge" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_hokyu_charge
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_hokyu/charge"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kaisou/powerup" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kaisou_powerup
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kaisou/powerup"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kousyou/getship" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kousyou_getship
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kousyou/getship"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kousyou/createitem" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kousyou_createitem
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kousyou/createitem"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kousyou/createship" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kousyou_createship
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kousyou/createship"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kousyou/createship_speedchange" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kousyou_createship_speedchange
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kousyou/createship_speedchange"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kousyou/destroyship" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kousyou_destroyship
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kousyou/destroyship"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_kousyou/destroyitem2" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_kousyou_destroyitem2
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_kousyou/destroyitem2"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_nyukyo/start" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_nyukyo_start
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_nyukyo/start"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_nyukyo/speedchange" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_nyukyo_speedchange
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_nyukyo/speedchange"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_map/start" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_map_start
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_map/start"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_member/updatedeckname" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_member_updatedeckname
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_member/updatedeckname"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_member/updatecomment" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_member_updatecomment
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_member/updatecomment"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_mission/result" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_mission_result
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_mission/result"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_sortie/battle" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_sortie_battle
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_sortie/battle"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_sortie/battleresult" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_sortie_battleresult
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_sortie/battleresult"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_hensei/combined" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_hensei_combined
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_hensei/combined"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_combined_battle/battle" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_combined_battle_battle
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_combined_battle/battle"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_combined_battle/airbattle" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_combined_battle_airbattle
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_combined_battle/airbattle"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_combined_battle/battleresult" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_combined_battle_battleresult
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_combined_battle/battleresult"); }
		}

		/// <summary>
		/// エンド ポイント "/kcsapi/api_req_combined_battle/goback_port" からのセッションを配信します。
		/// </summary>
		public IObservable<Session> api_req_combined_battle_goback_port
		{
			get { return this.ApiSessionSource.Where(x => x.PathAndQuery == "/kcsapi/api_req_combined_battle/goback_port"); }
		}

		// ReSharper restore InconsistentNaming
	}
}
