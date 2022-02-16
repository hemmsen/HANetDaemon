using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ClimateEntities Climate { get; }

		CounterEntities Counter { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		LightEntities Light { get; }

		LockEntities Lock { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersistentNotificationEntities PersistentNotification { get; }

		PersonEntities Person { get; }

		RemoteEntities Remote { get; }

		SceneEntities Scene { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		VacuumEntities Vacuum { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ClimateEntities Climate => new(_haContext);
		public CounterEntities Counter => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public LightEntities Light => new(_haContext);
		public LockEntities Lock => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersistentNotificationEntities PersistentNotification => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public RemoteEntities Remote => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public VacuumEntities Vacuum => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Aqara Magic Cube</summary>
		public AutomationEntity AqaraMagicCube => new(_haContext, "automation.aqara_magic_cube");
		///<summary>Eva Alarm temperatur for høj</summary>
		public AutomationEntity EvaAlarmTemperaturForHoj => new(_haContext, "automation.eva_alarm_temperatur_for_hoj");
		///<summary>Evas vindue lukket</summary>
		public AutomationEntity EvasVindueLukket => new(_haContext, "automation.evas_vindue_lukket");
		///<summary>Forminsk lysstyrke stuen</summary>
		public AutomationEntity ForminskLysstyrkw => new(_haContext, "automation.forminsk_lysstyrkw");
		///<summary>Forrige sang sonos</summary>
		public AutomationEntity ForrigeSangSonos => new(_haContext, "automation.forrige_sang_sonos");
		///<summary>Toggle play/pause</summary>
		public AutomationEntity NyAutomatisering => new(_haContext, "automation.ny_automatisering");
		///<summary>TV</summary>
		public AutomationEntity NyAutomatisering2 => new(_haContext, "automation.ny_automatisering_2");
		///<summary>Sonos next song</summary>
		public AutomationEntity NyAutomatisering3 => new(_haContext, "automation.ny_automatisering_3");
		///<summary>Eva vindue åbent</summary>
		public AutomationEntity NyAutomatisering4 => new(_haContext, "automation.ny_automatisering_4");
		///<summary>Forøj lya stue</summary>
		public AutomationEntity NyAutomatisering5 => new(_haContext, "automation.ny_automatisering_5");
		///<summary>Tænd lys hall</summary>
		public AutomationEntity NyAutomatisering6 => new(_haContext, "automation.ny_automatisering_6");
		///<summary>Eva lys remote</summary>
		public AutomationEntity NyAutomatisering7 => new(_haContext, "automation.ny_automatisering_7");
		///<summary>Set tv hjælper</summary>
		public AutomationEntity SetTvHjaelper => new(_haContext, "automation.set_tv_hjaelper");
		///<summary>sluk lys i soveværelse når telefon lader</summary>
		public AutomationEntity SlukLysISovevaerelseNarTelefonLader => new(_haContext, "automation.sluk_lys_i_sovevaerelse_nar_telefon_lader");
		///<summary>sonos volume down</summary>
		public AutomationEntity SonosVolumeDown => new(_haContext, "automation.sonos_volume_down");
		///<summary>Sonos volume up</summary>
		public AutomationEntity SonosVolumeUp => new(_haContext, "automation.sonos_volume_up");
		///<summary>Soveværelse lys</summary>
		public AutomationEntity SovevaerelseLys => new(_haContext, "automation.sovevaerelse_lys");
		///<summary>Soveværelse lys op</summary>
		public AutomationEntity SovevaerelseLysOp => new(_haContext, "automation.sovevaerelse_lys_op");
		///<summary>Tænd lys i stuen</summary>
		public AutomationEntity TaendLysIStuen => new(_haContext, "automation.taend_lys_i_stuen");
		///<summary>Tænd lys stue med tryk</summary>
		public AutomationEntity TaendLysStueMedTryk => new(_haContext, "automation.taend_lys_stue_med_tryk");
		///<summary>Vågen tænd kaffemaskine</summary>
		public AutomationEntity VagenTaendKaffemaskine => new(_haContext, "automation.vagen_taend_kaffemaskine");
	}

	public class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>barthroom_motion_sensor ias_zone</summary>
		public BinarySensorEntity BarthroomMotionSensorIasZone => new(_haContext, "binary_sensor.barthroom_motion_sensor_ias_zone");
		///<summary>bedroom_window on_off</summary>
		public BinarySensorEntity BedroomWindow => new(_haContext, "binary_sensor.bedroom_window");
		///<summary>JonnaPhone App Inactive</summary>
		public BinarySensorEntity JonnaphoneAppInactive => new(_haContext, "binary_sensor.jonnaphone_app_inactive");
		///<summary>JonnaPhone Bluetooth State</summary>
		public BinarySensorEntity JonnaphoneBluetoothState => new(_haContext, "binary_sensor.jonnaphone_bluetooth_state");
		///<summary>JonnaPhone Device Locked</summary>
		public BinarySensorEntity JonnaphoneDeviceLocked => new(_haContext, "binary_sensor.jonnaphone_device_locked");
		///<summary>JonnaPhone Device Secure</summary>
		public BinarySensorEntity JonnaphoneDeviceSecure => new(_haContext, "binary_sensor.jonnaphone_device_secure");
		///<summary>JonnaPhone Doze Mode</summary>
		public BinarySensorEntity JonnaphoneDozeMode => new(_haContext, "binary_sensor.jonnaphone_doze_mode");
		///<summary>JonnaPhone Headphones</summary>
		public BinarySensorEntity JonnaphoneHeadphones => new(_haContext, "binary_sensor.jonnaphone_headphones");
		///<summary>JonnaPhone High Accuracy Mode</summary>
		public BinarySensorEntity JonnaphoneHighAccuracyMode => new(_haContext, "binary_sensor.jonnaphone_high_accuracy_mode");
		///<summary>JonnaPhone Interactive</summary>
		public BinarySensorEntity JonnaphoneInteractive => new(_haContext, "binary_sensor.jonnaphone_interactive");
		///<summary>JonnaPhone Is Charging</summary>
		public BinarySensorEntity JonnaphoneIsCharging => new(_haContext, "binary_sensor.jonnaphone_is_charging");
		///<summary>JonnaPhone Keyguard Locked</summary>
		public BinarySensorEntity JonnaphoneKeyguardLocked => new(_haContext, "binary_sensor.jonnaphone_keyguard_locked");
		///<summary>JonnaPhone Keyguard Secure</summary>
		public BinarySensorEntity JonnaphoneKeyguardSecure => new(_haContext, "binary_sensor.jonnaphone_keyguard_secure");
		///<summary>JonnaPhone Mic Muted</summary>
		public BinarySensorEntity JonnaphoneMicMuted => new(_haContext, "binary_sensor.jonnaphone_mic_muted");
		///<summary>JonnaPhone Mobile Data</summary>
		public BinarySensorEntity JonnaphoneMobileData => new(_haContext, "binary_sensor.jonnaphone_mobile_data");
		///<summary>JonnaPhone Mobile Data Roaming</summary>
		public BinarySensorEntity JonnaphoneMobileDataRoaming => new(_haContext, "binary_sensor.jonnaphone_mobile_data_roaming");
		///<summary>JonnaPhone Music Active</summary>
		public BinarySensorEntity JonnaphoneMusicActive => new(_haContext, "binary_sensor.jonnaphone_music_active");
		///<summary>JonnaPhone Power Save</summary>
		public BinarySensorEntity JonnaphonePowerSave => new(_haContext, "binary_sensor.jonnaphone_power_save");
		///<summary>JonnaPhone Speakerphone</summary>
		public BinarySensorEntity JonnaphoneSpeakerphone => new(_haContext, "binary_sensor.jonnaphone_speakerphone");
		///<summary>JonnaPhone WiFi State</summary>
		public BinarySensorEntity JonnaphoneWifiState => new(_haContext, "binary_sensor.jonnaphone_wifi_state");
		///<summary>Vindue Eva 61992507 on_off</summary>
		public BinarySensorEntity LumiLumiSensorMagnetAq261992507OnOff => new(_haContext, "binary_sensor.lumi_lumi_sensor_magnet_aq2_61992507_on_off");
		///<summary>Move Power</summary>
		public BinarySensorEntity MovePower => new(_haContext, "binary_sensor.move_power");
		///<summary>Pixel 5 App Inactive</summary>
		public BinarySensorEntity Pixel5AppInactive => new(_haContext, "binary_sensor.pixel_5_app_inactive");
		///<summary>Pixel 5 Bluetooth State</summary>
		public BinarySensorEntity Pixel5BluetoothState => new(_haContext, "binary_sensor.pixel_5_bluetooth_state");
		///<summary>Pixel 5 Device Locked</summary>
		public BinarySensorEntity Pixel5DeviceLocked => new(_haContext, "binary_sensor.pixel_5_device_locked");
		///<summary>Pixel 5 Device Secure</summary>
		public BinarySensorEntity Pixel5DeviceSecure => new(_haContext, "binary_sensor.pixel_5_device_secure");
		///<summary>Pixel 5 Doze Mode</summary>
		public BinarySensorEntity Pixel5DozeMode => new(_haContext, "binary_sensor.pixel_5_doze_mode");
		///<summary>Pixel 5 Headphones</summary>
		public BinarySensorEntity Pixel5Headphones => new(_haContext, "binary_sensor.pixel_5_headphones");
		///<summary>Pixel 5 High Accuracy Mode</summary>
		public BinarySensorEntity Pixel5HighAccuracyMode => new(_haContext, "binary_sensor.pixel_5_high_accuracy_mode");
		///<summary>Pixel 5 Interactive</summary>
		public BinarySensorEntity Pixel5Interactive => new(_haContext, "binary_sensor.pixel_5_interactive");
		///<summary>Pixel 5 Is Charging</summary>
		public BinarySensorEntity Pixel5IsCharging => new(_haContext, "binary_sensor.pixel_5_is_charging");
		///<summary>Pixel 5 Keyguard Locked</summary>
		public BinarySensorEntity Pixel5KeyguardLocked => new(_haContext, "binary_sensor.pixel_5_keyguard_locked");
		///<summary>Pixel 5 Keyguard Secure</summary>
		public BinarySensorEntity Pixel5KeyguardSecure => new(_haContext, "binary_sensor.pixel_5_keyguard_secure");
		///<summary>Pixel 5 Mic Muted</summary>
		public BinarySensorEntity Pixel5MicMuted => new(_haContext, "binary_sensor.pixel_5_mic_muted");
		///<summary>Pixel 5 Mobile Data</summary>
		public BinarySensorEntity Pixel5MobileData => new(_haContext, "binary_sensor.pixel_5_mobile_data");
		///<summary>Pixel 5 Mobile Data Roaming</summary>
		public BinarySensorEntity Pixel5MobileDataRoaming => new(_haContext, "binary_sensor.pixel_5_mobile_data_roaming");
		///<summary>Pixel 5 Music Active</summary>
		public BinarySensorEntity Pixel5MusicActive => new(_haContext, "binary_sensor.pixel_5_music_active");
		///<summary>Pixel 5 Power Save</summary>
		public BinarySensorEntity Pixel5PowerSave => new(_haContext, "binary_sensor.pixel_5_power_save");
		///<summary>Pixel 5 Speakerphone</summary>
		public BinarySensorEntity Pixel5Speakerphone => new(_haContext, "binary_sensor.pixel_5_speakerphone");
		///<summary>Pixel 5 WiFi State</summary>
		public BinarySensorEntity Pixel5WifiState => new(_haContext, "binary_sensor.pixel_5_wifi_state");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>Roborock S6 MaxV Mop Attached</summary>
		public BinarySensorEntity RoborockS6MaxvMopAttached => new(_haContext, "binary_sensor.roborock_s6_maxv_mop_attached");
		///<summary>Roborock S6 MaxV Water Box Attached</summary>
		public BinarySensorEntity RoborockS6MaxvWaterBoxAttached => new(_haContext, "binary_sensor.roborock_s6_maxv_water_box_attached");
		///<summary>RPi Power status</summary>
		public BinarySensorEntity RpiPowerStatus => new(_haContext, "binary_sensor.rpi_power_status");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public class ClimateEntities
	{
		private readonly IHaContext _haContext;
		public ClimateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>bedroom_thermostat thermostat</summary>
		public ClimateEntity BedroomThermostatThermostat => new(_haContext, "climate.bedroom_thermostat_thermostat");
		///<summary>Eva</summary>
		public ClimateEntity NetatmoEva => new(_haContext, "climate.netatmo_eva");
		///<summary>Kontor</summary>
		public ClimateEntity NetatmoKontor => new(_haContext, "climate.netatmo_kontor");
		///<summary>Skur</summary>
		public ClimateEntity Skur => new(_haContext, "climate.skur");
	}

	public class CounterEntities
	{
		private readonly IHaContext _haContext;
		public CounterEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>DustbinEmptyCreditsLeft</summary>
		public CounterEntity Dustbinemptycreditsleft => new(_haContext, "counter.dustbinemptycreditsleft");
		///<summary>Eva vindue åbnet</summary>
		public CounterEntity EvaVindueAbnet => new(_haContext, "counter.eva_vindue_abnet");
	}

	public class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>LUMI lumi.curtain.acn002 ea012e00 window_covering</summary>
		public CoverEntity LumiLumiCurtainAcn002Ea012e00WindowCovering => new(_haContext, "cover.lumi_lumi_curtain_acn002_ea012e00_window_covering");
	}

	public class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>JonnaPhone</summary>
		public DeviceTrackerEntity Jonnaphone => new(_haContext, "device_tracker.jonnaphone");
		///<summary>MathiasPhone</summary>
		public DeviceTrackerEntity Pixel5 => new(_haContext, "device_tracker.pixel_5");
	}

	public class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Christmas</summary>
		public InputBooleanEntity Christmas => new(_haContext, "input_boolean.christmas");
		///<summary>CO2LevelToHighLivingroom</summary>
		public InputBooleanEntity Co2leveltohighlivingroom => new(_haContext, "input_boolean.co2leveltohighlivingroom");
		///<summary>EvaBlindsClosed</summary>
		public InputBooleanEntity Evablindsclosed => new(_haContext, "input_boolean.evablindsclosed");
		///<summary>ProfitecReady</summary>
		public InputBooleanEntity Profitecready => new(_haContext, "input_boolean.profitecready");
		///<summary>SkipNextVacuumCleanLivingroom</summary>
		public InputBooleanEntity Skipnextvacuumcleanlivingroom => new(_haContext, "input_boolean.skipnextvacuumcleanlivingroom");
		///<summary>TrashcanEmptyTomorrow</summary>
		public InputBooleanEntity Trashcanemptytomorrow => new(_haContext, "input_boolean.trashcanemptytomorrow");
	}

	public class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>BedroomWindowLastOpened</summary>
		public InputDatetimeEntity Bedroomwindowlastopened => new(_haContext, "input_datetime.bedroomwindowlastopened");
		///<summary>DailyVacuumCleanStartAt</summary>
		public InputDatetimeEntity Dailyvacuumcleanstartat => new(_haContext, "input_datetime.dailyvacuumcleanstartat");
		///<summary>NextAlarmMathias</summary>
		public InputDatetimeEntity Nextalarmmathias => new(_haContext, "input_datetime.nextalarmmathias");
		///<summary>recycleTrash</summary>
		public InputDatetimeEntity Recycletrash => new(_haContext, "input_datetime.recycletrash");
		///<summary>skraldespand</summary>
		public InputDatetimeEntity Skraldespand => new(_haContext, "input_datetime.skraldespand");
	}

	public class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dage til restaffald tømmes</summary>
		public InputNumberEntity DageTilRestaffaldTommes => new(_haContext, "input_number.dage_til_restaffald_tommes");
	}

	public class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Lights</summary>
		public LightEntity BedroomLights => new(_haContext, "light.bedroom_lights");
		///<summary>Eva lys level, light_color, on_off</summary>
		public LightEntity EvaLysLevelLightColorOnOff => new(_haContext, "light.eva_lys_level_light_color_on_off");
		///<summary>Hall lys level, on_off</summary>
		public LightEntity HallLysLevelOnOff => new(_haContext, "light.hall_lys_level_on_off");
		///<summary>Spisebord 2</summary>
		public LightEntity IkeaOfSwedenTradfriBulbE27WsOpal980lmE95300feLevelLightColorOnOff => new(_haContext, "light.ikea_of_sweden_tradfri_bulb_e27_ws_opal_980lm_e95300fe_level_light_color_on_off");
		///<summary>Køkken spots level, on_off</summary>
		public LightEntity KokkenSpotsLevelOnOff => new(_haContext, "light.kokken_spots_level_on_off");
		///<summary>Livingroom Lights</summary>
		public LightEntity LivingroomLights => new(_haContext, "light.livingroom_lights");
		///<summary>Eva blind on_off</summary>
		public LightEntity LumiLumiCurtainAcn002OnOff => new(_haContext, "light.lumi_lumi_curtain_acn002_on_off");
		///<summary>PhillipsTV</summary>
		public LightEntity Phillipstv => new(_haContext, "light.phillipstv");
		///<summary>Soveværelse 1 level, light_color, on_off</summary>
		public LightEntity Sovevarelse1LevelLightColorOnOff => new(_haContext, "light.sovevarelse_1_level_light_color_on_off");
		///<summary>Soveværelse 2 level, light_color, on_off</summary>
		public LightEntity Sovevarelse2LevelLightColorOnOff => new(_haContext, "light.sovevarelse_2_level_light_color_on_off");
		///<summary>Soveværelse 3 level, light_color, on_off</summary>
		public LightEntity Sovevarelse3LevelLightColorOnOff => new(_haContext, "light.sovevarelse_3_level_light_color_on_off");
		///<summary>Spisebord 2 level, light_color, on_off</summary>
		public LightEntity Spisebord2LevelLightColorOnOff => new(_haContext, "light.spisebord_2_level_light_color_on_off");
		///<summary>TVLys 69ab73fe level, light_color, on_off</summary>
		public LightEntity Tvlys69ab73feLevelLightColorOnOff => new(_haContext, "light.tvlys_69ab73fe_level_light_color_on_off");
	}

	public class LockEntities
	{
		private readonly IHaContext _haContext;
		public LockEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Hoveddøren door_lock</summary>
		public LockEntity HoveddorenDoorLock => new(_haContext, "lock.hoveddoren_door_lock");
	}

	public class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse</summary>
		public MediaPlayerEntity Badevaerelse => new(_haContext, "media_player.badevaerelse");
		///<summary>Fjernsyn i stuen</summary>
		public MediaPlayerEntity FjernsynIStuen => new(_haContext, "media_player.fjernsyn_i_stuen");
		///<summary>GoogleTV</summary>
		public MediaPlayerEntity Googletv => new(_haContext, "media_player.googletv");
		///<summary>Home mini</summary>
		public MediaPlayerEntity HomeMini => new(_haContext, "media_player.home_mini");
		///<summary>Kontor</summary>
		public MediaPlayerEntity Kontor => new(_haContext, "media_player.kontor");
		///<summary>Move</summary>
		public MediaPlayerEntity Move => new(_haContext, "media_player.move");
		///<summary>PhillipsTV</summary>
		public MediaPlayerEntity Phillipstv3 => new(_haContext, "media_player.phillipstv_3");
		///<summary>Soveværelse</summary>
		public MediaPlayerEntity Sovevaerelse => new(_haContext, "media_player.sovevaerelse");
		///<summary>SoveværelseCast</summary>
		public MediaPlayerEntity Sovevaerelsecast => new(_haContext, "media_player.sovevaerelsecast");
		///<summary>TV/Stue</summary>
		public MediaPlayerEntity TvStue => new(_haContext, "media_player.tv_stue");
	}

	public class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Badeværelse Bass</summary>
		public NumberEntity BadevaerelseBass => new(_haContext, "number.badevaerelse_bass");
		///<summary>Badeværelse Treble</summary>
		public NumberEntity BadevaerelseTreble => new(_haContext, "number.badevaerelse_treble");
		///<summary>Eva blind analog_output</summary>
		public NumberEntity EvaBlindPercentageOpen => new(_haContext, "number.eva_blind_percentage_open");
		///<summary>Kontor Bass</summary>
		public NumberEntity KontorBass => new(_haContext, "number.kontor_bass");
		///<summary>Kontor Treble</summary>
		public NumberEntity KontorTreble => new(_haContext, "number.kontor_treble");
		///<summary>Move Bass</summary>
		public NumberEntity MoveBass => new(_haContext, "number.move_bass");
		///<summary>Move Treble</summary>
		public NumberEntity MoveTreble => new(_haContext, "number.move_treble");
		///<summary>TV/Stue Bass</summary>
		public NumberEntity TvStueBass => new(_haContext, "number.tv_stue_bass");
		///<summary>TV/Stue Treble</summary>
		public NumberEntity TvStueTreble => new(_haContext, "number.tv_stue_treble");
	}

	public class PersistentNotificationEntities
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>New devices discovered</summary>
		public PersistentNotificationEntity ConfigEntryDiscovery => new(_haContext, "persistent_notification.config_entry_discovery");
	}

	public class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>admin</summary>
		public PersonEntity Admin => new(_haContext, "person.admin");
		///<summary>Jonna</summary>
		public PersonEntity Jonna => new(_haContext, "person.jonna");
		///<summary>Mathias</summary>
		public PersonEntity Mathias => new(_haContext, "person.mathias");
		///<summary>Mathias Hemmsen</summary>
		public PersonEntity MathiasHemmsen => new(_haContext, "person.mathias_hemmsen");
	}

	public class RemoteEntities
	{
		private readonly IHaContext _haContext;
		public RemoteEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>PhillipsTV</summary>
		public RemoteEntity Phillipstv => new(_haContext, "remote.phillipstv");
	}

	public class SceneEntities
	{
		private readonly IHaContext _haContext;
		public SceneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lys stue 30%</summary>
		public SceneEntity LysStue30 => new(_haContext, "scene.lys_stue_30");
	}

	public class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Netatmo Engelstoft 157</summary>
		public SelectEntity NetatmoEngelstoft157 => new(_haContext, "select.netatmo_engelstoft_157");
	}

	public class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>barthroom_motion_sensor power</summary>
		public NumericSensorEntity BarthroomMotionSensorPower => new(_haContext, "sensor.barthroom_motion_sensor_power");
		///<summary>bedroom_thermostat power</summary>
		public NumericSensorEntity BedroomThermostatPower => new(_haContext, "sensor.bedroom_thermostat_power");
		///<summary>engelstoft 157_uptime</summary>
		public NumericSensorEntity Engelstoft157Uptime => new(_haContext, "sensor.engelstoft_157_uptime");
		///<summary>Eva lys remote power</summary>
		public NumericSensorEntity EvaLysRemotePower => new(_haContext, "sensor.eva_lys_remote_power");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Hoveddøren power</summary>
		public NumericSensorEntity HoveddorenPower => new(_haContext, "sensor.hoveddoren_power");
		///<summary>IKEA of Sweden TRADFRI remote control 6fce0bfe power</summary>
		public NumericSensorEntity IkeaOfSwedenTradfriRemoteControl6fce0bfePower => new(_haContext, "sensor.ikea_of_sweden_tradfri_remote_control_6fce0bfe_power");
		///<summary>JonnaPhone Active Notification Count</summary>
		public NumericSensorEntity JonnaphoneActiveNotificationCount => new(_haContext, "sensor.jonnaphone_active_notification_count");
		///<summary>JonnaPhone App Memory</summary>
		public NumericSensorEntity JonnaphoneAppMemory => new(_haContext, "sensor.jonnaphone_app_memory");
		///<summary>JonnaPhone App Rx GB</summary>
		public NumericSensorEntity JonnaphoneAppRxGb => new(_haContext, "sensor.jonnaphone_app_rx_gb");
		///<summary>JonnaPhone App Tx GB</summary>
		public NumericSensorEntity JonnaphoneAppTxGb => new(_haContext, "sensor.jonnaphone_app_tx_gb");
		///<summary>JonnaPhone Battery Level</summary>
		public NumericSensorEntity JonnaphoneBatteryLevel => new(_haContext, "sensor.jonnaphone_battery_level");
		///<summary>JonnaPhone Battery Temperature</summary>
		public NumericSensorEntity JonnaphoneBatteryTemperature => new(_haContext, "sensor.jonnaphone_battery_temperature");
		///<summary>JonnaPhone Bluetooth Connection</summary>
		public NumericSensorEntity JonnaphoneBluetoothConnection => new(_haContext, "sensor.jonnaphone_bluetooth_connection");
		///<summary>JonnaPhone External Storage</summary>
		public NumericSensorEntity JonnaphoneExternalStorage => new(_haContext, "sensor.jonnaphone_external_storage");
		///<summary>JonnaPhone Internal Storage</summary>
		public NumericSensorEntity JonnaphoneInternalStorage => new(_haContext, "sensor.jonnaphone_internal_storage");
		///<summary>JonnaPhone Light Sensor</summary>
		public NumericSensorEntity JonnaphoneLightSensor => new(_haContext, "sensor.jonnaphone_light_sensor");
		///<summary>JonnaPhone Mobile Rx GB</summary>
		public NumericSensorEntity JonnaphoneMobileRxGb => new(_haContext, "sensor.jonnaphone_mobile_rx_gb");
		///<summary>JonnaPhone Mobile Tx GB</summary>
		public NumericSensorEntity JonnaphoneMobileTxGb => new(_haContext, "sensor.jonnaphone_mobile_tx_gb");
		///<summary>JonnaPhone Sleep Confidence</summary>
		public NumericSensorEntity JonnaphoneSleepConfidence => new(_haContext, "sensor.jonnaphone_sleep_confidence");
		///<summary>JonnaPhone Sleep Segment</summary>
		public NumericSensorEntity JonnaphoneSleepSegment => new(_haContext, "sensor.jonnaphone_sleep_segment");
		///<summary>JonnaPhone Steps Sensor</summary>
		public NumericSensorEntity JonnaphoneStepsSensor => new(_haContext, "sensor.jonnaphone_steps_sensor");
		///<summary>JonnaPhone Total Rx GB</summary>
		public NumericSensorEntity JonnaphoneTotalRxGb => new(_haContext, "sensor.jonnaphone_total_rx_gb");
		///<summary>JonnaPhone Total Tx GB</summary>
		public NumericSensorEntity JonnaphoneTotalTxGb => new(_haContext, "sensor.jonnaphone_total_tx_gb");
		///<summary>JonnaPhone WiFi Frequency</summary>
		public NumericSensorEntity JonnaphoneWifiFrequency => new(_haContext, "sensor.jonnaphone_wifi_frequency");
		///<summary>JonnaPhone WiFi Link Speed</summary>
		public NumericSensorEntity JonnaphoneWifiLinkSpeed => new(_haContext, "sensor.jonnaphone_wifi_link_speed");
		///<summary>JonnaPhone WiFi Signal Strength</summary>
		public NumericSensorEntity JonnaphoneWifiSignalStrength => new(_haContext, "sensor.jonnaphone_wifi_signal_strength");
		///<summary>Kaffemaskine electrical_measurement rms_current</summary>
		public NumericSensorEntity KaffemaskineElectricalMeasurementRmsCurrent => new(_haContext, "sensor.kaffemaskine_electrical_measurement_rms_current");
		///<summary>Kaffemaskine electrical_measurement rms_voltage</summary>
		public NumericSensorEntity KaffemaskineElectricalMeasurementRmsVoltage => new(_haContext, "sensor.kaffemaskine_electrical_measurement_rms_voltage");
		///<summary>Kaffemaskine smartenergy_metering</summary>
		public NumericSensorEntity KaffemaskineSmartenergyMetering => new(_haContext, "sensor.kaffemaskine_smartenergy_metering");
		///<summary>Kaffemaskine smartenergy_metering summation_delivered</summary>
		public NumericSensorEntity KaffemaskineSmartenergyMeteringSummationDelivered => new(_haContext, "sensor.kaffemaskine_smartenergy_metering_summation_delivered");
		///<summary>livingroom_cube power</summary>
		public NumericSensorEntity LumiLumiSensorCubePower => new(_haContext, "sensor.lumi_lumi_sensor_cube_power");
		///<summary>Vindue Eva 61992507 power</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq261992507Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_61992507_power");
		///<summary>bedroom_window power</summary>
		public NumericSensorEntity LumiLumiSensorMagnetAq2Power => new(_haContext, "sensor.lumi_lumi_sensor_magnet_aq2_power");
		///<summary>LUMI lumi.weather ccad5507 power</summary>
		public NumericSensorEntity LumiLumiWeatherCcad5507Power => new(_haContext, "sensor.lumi_lumi_weather_ccad5507_power");
		///<summary>LUMI lumi.weather ccad5507 pressure</summary>
		public NumericSensorEntity LumiLumiWeatherCcad5507Pressure => new(_haContext, "sensor.lumi_lumi_weather_ccad5507_pressure");
		///<summary>Repos humidity</summary>
		public NumericSensorEntity LumiLumiWeatherHumidity => new(_haContext, "sensor.lumi_lumi_weather_humidity");
		///<summary>Repos power</summary>
		public NumericSensorEntity LumiLumiWeatherPower => new(_haContext, "sensor.lumi_lumi_weather_power");
		///<summary>Repos pressure</summary>
		public NumericSensorEntity LumiLumiWeatherPressure => new(_haContext, "sensor.lumi_lumi_weather_pressure");
		///<summary>Repos temperature</summary>
		public NumericSensorEntity LumiLumiWeatherTemperature => new(_haContext, "sensor.lumi_lumi_weather_temperature");
		///<summary>Move Battery</summary>
		public NumericSensorEntity MoveBattery => new(_haContext, "sensor.move_battery");
		///<summary>Netatmo Engelstoft 157 (Indoor) CO2</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorCo2 => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_co2");
		///<summary>Netatmo Engelstoft 157 (Indoor) Engelstoft 157 Battery Percent</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorEngelstoft157BatteryPercent => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_engelstoft_157_battery_percent");
		///<summary>Netatmo Engelstoft 157 (Indoor) Engelstoft 157 Humidity</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorEngelstoft157Humidity => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_engelstoft_157_humidity");
		///<summary>Netatmo Engelstoft 157 (Indoor) Engelstoft 157 Temperature</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorEngelstoft157Temperature => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_engelstoft_157_temperature");
		///<summary>Netatmo Engelstoft 157 (Indoor) Humidity</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorHumidity => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_humidity");
		///<summary>Netatmo Engelstoft 157 (Indoor) Noise</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorNoise => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_noise");
		///<summary>Netatmo Engelstoft 157 (Indoor) Pressure</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorPressure => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_pressure");
		///<summary>Netatmo Engelstoft 157 (Indoor) Soveværelse Battery Percent</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorSovevaerelseBatteryPercent => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_sovevaerelse_battery_percent");
		///<summary>Netatmo Engelstoft 157 (Indoor) Soveværelse CO2</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorSovevaerelseCo2 => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_sovevaerelse_co2");
		///<summary>Netatmo Engelstoft 157 (Indoor) Soveværelse Humidity</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorSovevaerelseHumidity => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_sovevaerelse_humidity");
		///<summary>Netatmo Engelstoft 157 (Indoor) Soveværelse Temperature</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorSovevaerelseTemperature => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_sovevaerelse_temperature");
		///<summary>Netatmo Engelstoft 157 (Indoor) Temperature</summary>
		public NumericSensorEntity NetatmoEngelstoft157IndoorTemperature => new(_haContext, "sensor.netatmo_engelstoft_157_indoor_temperature");
		///<summary>Netatmo Engelstoft 157 (Skur) CO2</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurCo2 => new(_haContext, "sensor.netatmo_engelstoft_157_skur_co2");
		///<summary>Netatmo Engelstoft 157 (Skur) Humidity</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurHumidity => new(_haContext, "sensor.netatmo_engelstoft_157_skur_humidity");
		///<summary>Netatmo Engelstoft 157 (Skur) Module Battery Percent</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurModuleBatteryPercent => new(_haContext, "sensor.netatmo_engelstoft_157_skur_module_battery_percent");
		///<summary>Netatmo Engelstoft 157 (Skur) Module Humidity</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurModuleHumidity => new(_haContext, "sensor.netatmo_engelstoft_157_skur_module_humidity");
		///<summary>Netatmo Engelstoft 157 (Skur) Module Temperature</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurModuleTemperature => new(_haContext, "sensor.netatmo_engelstoft_157_skur_module_temperature");
		///<summary>Netatmo Engelstoft 157 (Skur) Noise</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurNoise => new(_haContext, "sensor.netatmo_engelstoft_157_skur_noise");
		///<summary>Netatmo Engelstoft 157 (Skur) Pressure</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurPressure => new(_haContext, "sensor.netatmo_engelstoft_157_skur_pressure");
		///<summary>Netatmo Engelstoft 157 (Skur) Regnmåler Battery Percent</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurRegnmalerBatteryPercent => new(_haContext, "sensor.netatmo_engelstoft_157_skur_regnmaler_battery_percent");
		///<summary>Netatmo Engelstoft 157 (Skur) Regnmåler Rain</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurRegnmalerRain => new(_haContext, "sensor.netatmo_engelstoft_157_skur_regnmaler_rain");
		///<summary>Netatmo Engelstoft 157 (Skur) Regnmåler Rain today</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurRegnmalerRainToday => new(_haContext, "sensor.netatmo_engelstoft_157_skur_regnmaler_rain_today");
		///<summary>Netatmo Engelstoft 157 (Skur) Temperature</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurTemperature => new(_haContext, "sensor.netatmo_engelstoft_157_skur_temperature");
		///<summary>Netatmo Engelstoft 157 (Skur) Vindmåler Battery Percent</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurVindmalerBatteryPercent => new(_haContext, "sensor.netatmo_engelstoft_157_skur_vindmaler_battery_percent");
		///<summary>Netatmo Engelstoft 157 (Skur) Vindmåler Wind Strength</summary>
		public NumericSensorEntity NetatmoEngelstoft157SkurVindmalerWindStrength => new(_haContext, "sensor.netatmo_engelstoft_157_skur_vindmaler_wind_strength");
		///<summary>LUMI lumi.weather ccad5507 humidity</summary>
		public NumericSensorEntity OfficeHumidity => new(_haContext, "sensor.office_humidity");
		///<summary>LUMI lumi.weather ccad5507 temperature</summary>
		public NumericSensorEntity OfficeTemperature => new(_haContext, "sensor.office_temperature");
		///<summary>Pixel 5 Active Notification Count</summary>
		public NumericSensorEntity Pixel5ActiveNotificationCount => new(_haContext, "sensor.pixel_5_active_notification_count");
		///<summary>Pixel 5 App Memory</summary>
		public NumericSensorEntity Pixel5AppMemory => new(_haContext, "sensor.pixel_5_app_memory");
		///<summary>Pixel 5 App Rx GB</summary>
		public NumericSensorEntity Pixel5AppRxGb => new(_haContext, "sensor.pixel_5_app_rx_gb");
		///<summary>Pixel 5 App Tx GB</summary>
		public NumericSensorEntity Pixel5AppTxGb => new(_haContext, "sensor.pixel_5_app_tx_gb");
		///<summary>Pixel 5 Battery Level</summary>
		public NumericSensorEntity Pixel5BatteryLevel => new(_haContext, "sensor.pixel_5_battery_level");
		///<summary>Pixel 5 Battery Temperature</summary>
		public NumericSensorEntity Pixel5BatteryTemperature => new(_haContext, "sensor.pixel_5_battery_temperature");
		///<summary>Pixel 5 Bluetooth Connection</summary>
		public NumericSensorEntity Pixel5BluetoothConnection => new(_haContext, "sensor.pixel_5_bluetooth_connection");
		///<summary>Pixel 5 External Storage</summary>
		public NumericSensorEntity Pixel5ExternalStorage => new(_haContext, "sensor.pixel_5_external_storage");
		///<summary>Pixel 5 Internal Storage</summary>
		public NumericSensorEntity Pixel5InternalStorage => new(_haContext, "sensor.pixel_5_internal_storage");
		///<summary>Pixel 5 Light Sensor</summary>
		public NumericSensorEntity Pixel5LightSensor => new(_haContext, "sensor.pixel_5_light_sensor");
		///<summary>Pixel 5 Mobile Rx GB</summary>
		public NumericSensorEntity Pixel5MobileRxGb => new(_haContext, "sensor.pixel_5_mobile_rx_gb");
		///<summary>Pixel 5 Mobile Tx GB</summary>
		public NumericSensorEntity Pixel5MobileTxGb => new(_haContext, "sensor.pixel_5_mobile_tx_gb");
		///<summary>Pixel 5 Pressure Sensor</summary>
		public NumericSensorEntity Pixel5PressureSensor => new(_haContext, "sensor.pixel_5_pressure_sensor");
		///<summary>Pixel 5 Sleep Confidence</summary>
		public NumericSensorEntity Pixel5SleepConfidence => new(_haContext, "sensor.pixel_5_sleep_confidence");
		///<summary>Pixel 5 Sleep Segment</summary>
		public NumericSensorEntity Pixel5SleepSegment => new(_haContext, "sensor.pixel_5_sleep_segment");
		///<summary>Pixel 5 Steps Sensor</summary>
		public NumericSensorEntity Pixel5StepsSensor => new(_haContext, "sensor.pixel_5_steps_sensor");
		///<summary>Pixel 5 Total Rx GB</summary>
		public NumericSensorEntity Pixel5TotalRxGb => new(_haContext, "sensor.pixel_5_total_rx_gb");
		///<summary>Pixel 5 Total Tx GB</summary>
		public NumericSensorEntity Pixel5TotalTxGb => new(_haContext, "sensor.pixel_5_total_tx_gb");
		///<summary>Pixel 5 WiFi Frequency</summary>
		public NumericSensorEntity Pixel5WifiFrequency => new(_haContext, "sensor.pixel_5_wifi_frequency");
		///<summary>Pixel 5 WiFi Link Speed</summary>
		public NumericSensorEntity Pixel5WifiLinkSpeed => new(_haContext, "sensor.pixel_5_wifi_link_speed");
		///<summary>Pixel 5 WiFi Signal Strength</summary>
		public NumericSensorEntity Pixel5WifiSignalStrength => new(_haContext, "sensor.pixel_5_wifi_signal_strength");
		///<summary>Radiatortermostat Eva 1 Battery Percent</summary>
		public NumericSensorEntity RadiatortermostatEva1BatteryPercent => new(_haContext, "sensor.radiatortermostat_eva_1_battery_percent");
		///<summary>Radiatortermostat Kontor 1 Battery Percent</summary>
		public NumericSensorEntity RadiatortermostatKontor1BatteryPercent => new(_haContext, "sensor.radiatortermostat_kontor_1_battery_percent");
		///<summary>Roborock S6 MaxV Last Clean Area</summary>
		public NumericSensorEntity RoborockS6MaxvLastCleanArea => new(_haContext, "sensor.roborock_s6_maxv_last_clean_area");
		///<summary>Roborock S6 MaxV Last Clean Duration</summary>
		public NumericSensorEntity RoborockS6MaxvLastCleanDuration => new(_haContext, "sensor.roborock_s6_maxv_last_clean_duration");
		///<summary>Soveværelse remote power</summary>
		public NumericSensorEntity SovevarelseRemotePower => new(_haContext, "sensor.sovevarelse_remote_power");
		///<summary>bedroom_thermostat thermostat hvac_action</summary>
		public SensorEntity BedroomThermostatThermostatHvacAction => new(_haContext, "sensor.bedroom_thermostat_thermostat_hvac_action");
		///<summary>engelstoft 157_current_version</summary>
		public SensorEntity Engelstoft157CurrentVersion => new(_haContext, "sensor.engelstoft_157_current_version");
		///<summary>engelstoft 157_last_restart</summary>
		public SensorEntity Engelstoft157LastRestart => new(_haContext, "sensor.engelstoft_157_last_restart");
		///<summary>engelstoft 157_local_ip</summary>
		public SensorEntity Engelstoft157LocalIp => new(_haContext, "sensor.engelstoft_157_local_ip");
		///<summary>engelstoft 157_new_version</summary>
		public SensorEntity Engelstoft157NewVersion => new(_haContext, "sensor.engelstoft_157_new_version");
		///<summary>engelstoft 157_status</summary>
		public SensorEntity Engelstoft157Status => new(_haContext, "sensor.engelstoft_157_status");
		///<summary>Home Assistant Operating System: Newest Version</summary>
		public SensorEntity HomeAssistantOperatingSystemNewestVersion => new(_haContext, "sensor.home_assistant_operating_system_newest_version");
		///<summary>JonnaPhone App Importance</summary>
		public SensorEntity JonnaphoneAppImportance => new(_haContext, "sensor.jonnaphone_app_importance");
		///<summary>JonnaPhone App Standby Bucket</summary>
		public SensorEntity JonnaphoneAppStandbyBucket => new(_haContext, "sensor.jonnaphone_app_standby_bucket");
		///<summary>JonnaPhone Audio Mode</summary>
		public SensorEntity JonnaphoneAudioMode => new(_haContext, "sensor.jonnaphone_audio_mode");
		///<summary>JonnaPhone Battery Health</summary>
		public SensorEntity JonnaphoneBatteryHealth => new(_haContext, "sensor.jonnaphone_battery_health");
		///<summary>JonnaPhone Battery State</summary>
		public SensorEntity JonnaphoneBatteryState => new(_haContext, "sensor.jonnaphone_battery_state");
		///<summary>JonnaPhone Charger Type</summary>
		public SensorEntity JonnaphoneChargerType => new(_haContext, "sensor.jonnaphone_charger_type");
		///<summary>JonnaPhone Current Time Zone</summary>
		public SensorEntity JonnaphoneCurrentTimeZone => new(_haContext, "sensor.jonnaphone_current_time_zone");
		///<summary>JonnaPhone Current Version</summary>
		public SensorEntity JonnaphoneCurrentVersion => new(_haContext, "sensor.jonnaphone_current_version");
		///<summary>JonnaPhone Detected Activity</summary>
		public SensorEntity JonnaphoneDetectedActivity => new(_haContext, "sensor.jonnaphone_detected_activity");
		///<summary>JonnaPhone Do Not Disturb Sensor</summary>
		public SensorEntity JonnaphoneDoNotDisturbSensor => new(_haContext, "sensor.jonnaphone_do_not_disturb_sensor");
		///<summary>JonnaPhone Geocoded Location</summary>
		public SensorEntity JonnaphoneGeocodedLocation => new(_haContext, "sensor.jonnaphone_geocoded_location");
		///<summary>JonnaPhone Last Notification</summary>
		public SensorEntity JonnaphoneLastNotification => new(_haContext, "sensor.jonnaphone_last_notification");
		///<summary>JonnaPhone Last Reboot</summary>
		public SensorEntity JonnaphoneLastReboot => new(_haContext, "sensor.jonnaphone_last_reboot");
		///<summary>JonnaPhone Last Removed Notification</summary>
		public SensorEntity JonnaphoneLastRemovedNotification => new(_haContext, "sensor.jonnaphone_last_removed_notification");
		///<summary>JonnaPhone Last Update Trigger</summary>
		public SensorEntity JonnaphoneLastUpdateTrigger => new(_haContext, "sensor.jonnaphone_last_update_trigger");
		///<summary>JonnaPhone Media Session</summary>
		public SensorEntity JonnaphoneMediaSession => new(_haContext, "sensor.jonnaphone_media_session");
		///<summary>JonnaPhone Next Alarm</summary>
		public SensorEntity JonnaphoneNextAlarm => new(_haContext, "sensor.jonnaphone_next_alarm");
		///<summary>JonnaPhone Phone State</summary>
		public SensorEntity JonnaphonePhoneState => new(_haContext, "sensor.jonnaphone_phone_state");
		///<summary>JonnaPhone Proximity Sensor</summary>
		public SensorEntity JonnaphoneProximitySensor => new(_haContext, "sensor.jonnaphone_proximity_sensor");
		///<summary>JonnaPhone Public IP Address</summary>
		public SensorEntity JonnaphonePublicIpAddress => new(_haContext, "sensor.jonnaphone_public_ip_address");
		///<summary>JonnaPhone Ringer Mode</summary>
		public SensorEntity JonnaphoneRingerMode => new(_haContext, "sensor.jonnaphone_ringer_mode");
		///<summary>JonnaPhone SIM 1</summary>
		public SensorEntity JonnaphoneSim1 => new(_haContext, "sensor.jonnaphone_sim_1");
		///<summary>JonnaPhone SIM 2</summary>
		public SensorEntity JonnaphoneSim2 => new(_haContext, "sensor.jonnaphone_sim_2");
		///<summary>JonnaPhone Volume Level Alarm</summary>
		public SensorEntity JonnaphoneVolumeLevelAlarm => new(_haContext, "sensor.jonnaphone_volume_level_alarm");
		///<summary>JonnaPhone Volume Level Call</summary>
		public SensorEntity JonnaphoneVolumeLevelCall => new(_haContext, "sensor.jonnaphone_volume_level_call");
		///<summary>JonnaPhone Volume Level Music</summary>
		public SensorEntity JonnaphoneVolumeLevelMusic => new(_haContext, "sensor.jonnaphone_volume_level_music");
		///<summary>JonnaPhone Volume Level Ringer</summary>
		public SensorEntity JonnaphoneVolumeLevelRinger => new(_haContext, "sensor.jonnaphone_volume_level_ringer");
		///<summary>JonnaPhone WiFi BSSID</summary>
		public SensorEntity JonnaphoneWifiBssid => new(_haContext, "sensor.jonnaphone_wifi_bssid");
		///<summary>JonnaPhone WiFi Connection</summary>
		public SensorEntity JonnaphoneWifiConnection => new(_haContext, "sensor.jonnaphone_wifi_connection");
		///<summary>JonnaPhone WiFi IP Address</summary>
		public SensorEntity JonnaphoneWifiIpAddress => new(_haContext, "sensor.jonnaphone_wifi_ip_address");
		///<summary>Netatmo Engelstoft 157 (Skur) Vindmåler Direction</summary>
		public SensorEntity NetatmoEngelstoft157SkurVindmalerDirection => new(_haContext, "sensor.netatmo_engelstoft_157_skur_vindmaler_direction");
		public SensorEntity NetdaemonStatus => new(_haContext, "sensor.netdaemon_status");
		///<summary>Pixel 5 App Importance</summary>
		public SensorEntity Pixel5AppImportance => new(_haContext, "sensor.pixel_5_app_importance");
		///<summary>Pixel 5 App Standby Bucket</summary>
		public SensorEntity Pixel5AppStandbyBucket => new(_haContext, "sensor.pixel_5_app_standby_bucket");
		///<summary>Pixel 5 Audio Mode</summary>
		public SensorEntity Pixel5AudioMode => new(_haContext, "sensor.pixel_5_audio_mode");
		///<summary>Pixel 5 Battery Health</summary>
		public SensorEntity Pixel5BatteryHealth => new(_haContext, "sensor.pixel_5_battery_health");
		///<summary>Pixel 5 Battery State</summary>
		public SensorEntity Pixel5BatteryState => new(_haContext, "sensor.pixel_5_battery_state");
		///<summary>Pixel 5 Charger Type</summary>
		public SensorEntity Pixel5ChargerType => new(_haContext, "sensor.pixel_5_charger_type");
		///<summary>Pixel 5 Current Time Zone</summary>
		public SensorEntity Pixel5CurrentTimeZone => new(_haContext, "sensor.pixel_5_current_time_zone");
		///<summary>Pixel 5 Current Version</summary>
		public SensorEntity Pixel5CurrentVersion => new(_haContext, "sensor.pixel_5_current_version");
		///<summary>Pixel 5 Detected Activity</summary>
		public SensorEntity Pixel5DetectedActivity => new(_haContext, "sensor.pixel_5_detected_activity");
		///<summary>Pixel 5 Do Not Disturb Sensor</summary>
		public SensorEntity Pixel5DoNotDisturbSensor => new(_haContext, "sensor.pixel_5_do_not_disturb_sensor");
		///<summary>Pixel 5 Geocoded Location</summary>
		public SensorEntity Pixel5GeocodedLocation => new(_haContext, "sensor.pixel_5_geocoded_location");
		///<summary>Pixel 5 Last Notification</summary>
		public SensorEntity Pixel5LastNotification => new(_haContext, "sensor.pixel_5_last_notification");
		///<summary>Pixel 5 Last Reboot</summary>
		public SensorEntity Pixel5LastReboot => new(_haContext, "sensor.pixel_5_last_reboot");
		///<summary>Pixel 5 Last Removed Notification</summary>
		public SensorEntity Pixel5LastRemovedNotification => new(_haContext, "sensor.pixel_5_last_removed_notification");
		///<summary>Pixel 5 Last Update Trigger</summary>
		public SensorEntity Pixel5LastUpdateTrigger => new(_haContext, "sensor.pixel_5_last_update_trigger");
		///<summary>Pixel 5 Media Session</summary>
		public SensorEntity Pixel5MediaSession => new(_haContext, "sensor.pixel_5_media_session");
		///<summary>Pixel 5 Next Alarm</summary>
		public SensorEntity Pixel5NextAlarm => new(_haContext, "sensor.pixel_5_next_alarm");
		///<summary>Pixel 5 Phone State</summary>
		public SensorEntity Pixel5PhoneState => new(_haContext, "sensor.pixel_5_phone_state");
		///<summary>Pixel 5 Proximity Sensor</summary>
		public SensorEntity Pixel5ProximitySensor => new(_haContext, "sensor.pixel_5_proximity_sensor");
		///<summary>Pixel 5 Public IP Address</summary>
		public SensorEntity Pixel5PublicIpAddress => new(_haContext, "sensor.pixel_5_public_ip_address");
		///<summary>Pixel 5 Ringer Mode</summary>
		public SensorEntity Pixel5RingerMode => new(_haContext, "sensor.pixel_5_ringer_mode");
		///<summary>Pixel 5 SIM 1</summary>
		public SensorEntity Pixel5Sim1 => new(_haContext, "sensor.pixel_5_sim_1");
		///<summary>Pixel 5 SIM 2</summary>
		public SensorEntity Pixel5Sim2 => new(_haContext, "sensor.pixel_5_sim_2");
		///<summary>Pixel 5 Volume Level Alarm</summary>
		public SensorEntity Pixel5VolumeLevelAlarm => new(_haContext, "sensor.pixel_5_volume_level_alarm");
		///<summary>Pixel 5 Volume Level Call</summary>
		public SensorEntity Pixel5VolumeLevelCall => new(_haContext, "sensor.pixel_5_volume_level_call");
		///<summary>Pixel 5 Volume Level Music</summary>
		public SensorEntity Pixel5VolumeLevelMusic => new(_haContext, "sensor.pixel_5_volume_level_music");
		///<summary>Pixel 5 Volume Level Ringer</summary>
		public SensorEntity Pixel5VolumeLevelRinger => new(_haContext, "sensor.pixel_5_volume_level_ringer");
		///<summary>Pixel 5 WiFi BSSID</summary>
		public SensorEntity Pixel5WifiBssid => new(_haContext, "sensor.pixel_5_wifi_bssid");
		///<summary>Pixel 5 WiFi Connection</summary>
		public SensorEntity Pixel5WifiConnection => new(_haContext, "sensor.pixel_5_wifi_connection");
		///<summary>Pixel 5 WiFi IP Address</summary>
		public SensorEntity Pixel5WifiIpAddress => new(_haContext, "sensor.pixel_5_wifi_ip_address");
		///<summary>Roborock S6 MaxV Last Clean End</summary>
		public SensorEntity RoborockS6MaxvLastCleanEnd => new(_haContext, "sensor.roborock_s6_maxv_last_clean_end");
		///<summary>Roborock S6 MaxV Last Clean Start</summary>
		public SensorEntity RoborockS6MaxvLastCleanStart => new(_haContext, "sensor.roborock_s6_maxv_last_clean_start");
		///<summary>TV/Stue Audio Input Format</summary>
		public SensorEntity TvStueAudioInputFormat => new(_haContext, "sensor.tv_stue_audio_input_format");
	}

	public class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Kaffemaskine on_off</summary>
		public SwitchEntity KaffemaskineOnOff => new(_haContext, "switch.kaffemaskine_on_off");
		public SwitchEntity NetdaemonAffaldvarmeapp => new(_haContext, "switch.netdaemon_affaldvarmeapp");
		public SwitchEntity NetdaemonBedroomapp => new(_haContext, "switch.netdaemon_bedroomapp");
		public SwitchEntity NetdaemonCo2checkerapp => new(_haContext, "switch.netdaemon_co2checkerapp");
		public SwitchEntity NetdaemonEvablindsapp => new(_haContext, "switch.netdaemon_evablindsapp");
		public SwitchEntity NetdaemonEvaclimateapp => new(_haContext, "switch.netdaemon_evaclimateapp");
		public SwitchEntity NetdaemonNetatmooutdoorapp => new(_haContext, "switch.netdaemon_netatmooutdoorapp");
		public SwitchEntity NetdaemonProfitecapp => new(_haContext, "switch.netdaemon_profitecapp");
		public SwitchEntity NetdaemonVacuumapp => new(_haContext, "switch.netdaemon_vacuumapp");
		public SwitchEntity NetdaemonWakeupturnonespressomachineapp => new(_haContext, "switch.netdaemon_wakeupturnonespressomachineapp");
		///<summary>Soveværelse Weekdays Alarm 06:25</summary>
		public SwitchEntity SonosAlarm1 => new(_haContext, "switch.sonos_alarm_1");
		///<summary>Soveværelse Weekdays Alarm 07:05</summary>
		public SwitchEntity SonosAlarm11 => new(_haContext, "switch.sonos_alarm_11");
		///<summary>Kontor Daily Alarm 07:00</summary>
		public SwitchEntity SonosAlarm115 => new(_haContext, "switch.sonos_alarm_115");
		///<summary>Soveværelse Weekdays Alarm 06:30</summary>
		public SwitchEntity SonosAlarm21 => new(_haContext, "switch.sonos_alarm_21");
		///<summary>Soveværelse Weekdays Alarm 07:45</summary>
		public SwitchEntity SonosAlarm5 => new(_haContext, "switch.sonos_alarm_5");
		///<summary>Soveværelse Weekends Alarm 08:30</summary>
		public SwitchEntity SonosAlarm59 => new(_haContext, "switch.sonos_alarm_59");
		///<summary>Soveværelse Daily Alarm 16:00</summary>
		public SwitchEntity SonosAlarm9 => new(_haContext, "switch.sonos_alarm_9");
		///<summary>Badeværelse Crossfade</summary>
		public SwitchEntity SonosBadevaerelseCrossfade => new(_haContext, "switch.sonos_badevaerelse_crossfade");
		///<summary>Kontor Crossfade</summary>
		public SwitchEntity SonosKontorCrossfade => new(_haContext, "switch.sonos_kontor_crossfade");
		///<summary>Move Crossfade</summary>
		public SwitchEntity SonosMoveCrossfade => new(_haContext, "switch.sonos_move_crossfade");
		///<summary>Soveværelse Crossfade</summary>
		public SwitchEntity SonosSovevaerelseCrossfade => new(_haContext, "switch.sonos_sovevaerelse_crossfade");
		///<summary>TV/Stue Crossfade</summary>
		public SwitchEntity SonosTvStueCrossfade => new(_haContext, "switch.sonos_tv_stue_crossfade");
		///<summary>TV/Stue Night Sound</summary>
		public SwitchEntity SonosTvStueNightSound => new(_haContext, "switch.sonos_tv_stue_night_sound");
		///<summary>TV/Stue Speech Enhancement</summary>
		public SwitchEntity SonosTvStueSpeechEnhancement => new(_haContext, "switch.sonos_tv_stue_speech_enhancement");
		///<summary>TV/Stue Status Light</summary>
		public SwitchEntity SonosTvStueStatusLight => new(_haContext, "switch.sonos_tv_stue_status_light");
		///<summary>TV/Stue Subwoofer Enabled</summary>
		public SwitchEntity SonosTvStueSubwooferEnabled => new(_haContext, "switch.sonos_tv_stue_subwoofer_enabled");
		///<summary>TV/Stue Surround Enabled</summary>
		public SwitchEntity SonosTvStueSurroundEnabled => new(_haContext, "switch.sonos_tv_stue_surround_enabled");
	}

	public class VacuumEntities
	{
		private readonly IHaContext _haContext;
		public VacuumEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Roborock S6 MaxV</summary>
		public VacuumEntity RoborockS6Maxv => new(_haContext, "vacuum.roborock_s6_maxv");
	}

	public class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Engelstoft 157</summary>
		public WeatherEntity Engelstoft157 => new(_haContext, "weather.engelstoft_157");
	}

	public class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Engelstoft 157</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
		///<summary>Kamstrup</summary>
		public ZoneEntity Kamstrup => new(_haContext, "zone.kamstrup");
		///<summary>Nonbo mark</summary>
		public ZoneEntity NonboMark => new(_haContext, "zone.nonbo_mark");
		///<summary>Trifork</summary>
		public ZoneEntity Trifork => new(_haContext, "zone.trifork");
	}

	public record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ClimateEntity : Entity<ClimateEntity, EntityState<ClimateAttributes>, ClimateAttributes>
	{
		public ClimateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ClimateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CounterEntity : Entity<CounterEntity, EntityState<CounterAttributes>, CounterAttributes>
	{
		public CounterEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CounterEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LockEntity : Entity<LockEntity, EntityState<LockAttributes>, LockAttributes>
	{
		public LockEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LockEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersistentNotificationEntity : Entity<PersistentNotificationEntity, EntityState<PersistentNotificationAttributes>, PersistentNotificationAttributes>
	{
		public PersistentNotificationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersistentNotificationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record RemoteEntity : Entity<RemoteEntity, EntityState<RemoteAttributes>, RemoteAttributes>
	{
		public RemoteEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public RemoteEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record VacuumEntity : Entity<VacuumEntity, EntityState<VacuumAttributes>, VacuumAttributes>
	{
		public VacuumEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public VacuumEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("ignoring_battery_optimizations")]
		public bool? IgnoringBatteryOptimizations { get; init; }

		[JsonPropertyName("newest_version")]
		public string? NewestVersion { get; init; }

		[JsonPropertyName("power_source")]
		public string? PowerSource { get; init; }

		[JsonPropertyName("release_notes")]
		public string? ReleaseNotes { get; init; }
	}

	public record ClimateAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("current_temperature")]
		public double? CurrentTemperature { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("heating_power_request")]
		public double? HeatingPowerRequest { get; init; }

		[JsonPropertyName("hvac_action")]
		public string? HvacAction { get; init; }

		[JsonPropertyName("hvac_modes")]
		public object? HvacModes { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max_temp")]
		public double? MaxTemp { get; init; }

		[JsonPropertyName("min_temp")]
		public double? MinTemp { get; init; }

		[JsonPropertyName("occupied_heating_setpoint")]
		public double? OccupiedHeatingSetpoint { get; init; }

		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("selected_schedule")]
		public string? SelectedSchedule { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("system_mode")]
		public string? SystemMode { get; init; }

		[JsonPropertyName("target_temp_step")]
		public double? TargetTempStep { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }
	}

	public record CounterAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public double? Initial { get; init; }

		[JsonPropertyName("maximum")]
		public double? Maximum { get; init; }

		[JsonPropertyName("minimum")]
		public double? Minimum { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public record CoverAttributes
	{
		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("day")]
		public double? Day { get; init; }

		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("month")]
		public double? Month { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("year")]
		public double? Year { get; init; }
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public object? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public record LightAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("color_temp")]
		public double? ColorTemp { get; init; }

		[JsonPropertyName("effect")]
		public string? Effect { get; init; }

		[JsonPropertyName("effect_list")]
		public object? EffectList { get; init; }

		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("off_brightness")]
		public object? OffBrightness { get; init; }

		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public object? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }
	}

	public record LockAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("app_id")]
		public string? AppId { get; init; }

		[JsonPropertyName("app_name")]
		public string? AppName { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("entity_picture_local")]
		public object? EntityPictureLocal { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }

		[JsonPropertyName("media_album_name")]
		public string? MediaAlbumName { get; init; }

		[JsonPropertyName("media_artist")]
		public string? MediaArtist { get; init; }

		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		[JsonPropertyName("media_duration")]
		public double? MediaDuration { get; init; }

		[JsonPropertyName("media_position")]
		public double? MediaPosition { get; init; }

		[JsonPropertyName("media_position_updated_at")]
		public string? MediaPositionUpdatedAt { get; init; }

		[JsonPropertyName("media_title")]
		public string? MediaTitle { get; init; }

		[JsonPropertyName("queue_position")]
		public double? QueuePosition { get; init; }

		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }

		[JsonPropertyName("sonos_group")]
		public object? SonosGroup { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("source_list")]
		public object? SourceList { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public record NumberAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public record PersistentNotificationAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("message")]
		public string? Message { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source")]
		public string? Source { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public record RemoteAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record SceneAttributes
	{
		[JsonPropertyName("entity_id")]
		public object? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }
	}

	public record SelectAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("android.appInfo_com.android.chrome")]
		public string? AndroidappInfoComandroidchrome { get; init; }

		[JsonPropertyName("android.appInfo_com.android.providers.downloads")]
		public string? AndroidappInfoComandroidprovidersdownloads { get; init; }

		[JsonPropertyName("android.appInfo_com.facebook.katana")]
		public string? AndroidappInfoComfacebookkatana { get; init; }

		[JsonPropertyName("android.appInfo_com.facebook.orca")]
		public string? AndroidappInfoComfacebookorca { get; init; }

		[JsonPropertyName("android.appInfo_com.google.android.apps.maps")]
		public string? AndroidappInfoComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.appInfo_com.google.android.apps.photos")]
		public string? AndroidappInfoComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.appInfo_com.google.android.dialer")]
		public string? AndroidappInfoComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.appInfo_com.google.android.googlequicksearchbox")]
		public string? AndroidappInfoComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.appInfo_com.instagram.android")]
		public string? AndroidappInfoCominstagramandroid { get; init; }

		[JsonPropertyName("android.appInfo_com.lunarway.app")]
		public string? AndroidappInfoComlunarwayapp { get; init; }

		[JsonPropertyName("android.appInfo_com.microsoft.office.outlook")]
		public string? AndroidappInfoCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.appInfo_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidappInfoComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.appInfo_com.netflix.mediaclient")]
		public string? AndroidappInfoComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.appInfo_com.oculus.twilight")]
		public string? AndroidappInfoComoculustwilight { get; init; }

		[JsonPropertyName("android.appInfo_com.pinterest")]
		public string? AndroidappInfoCompinterest { get; init; }

		[JsonPropertyName("android.appInfo_com.podimo")]
		public string? AndroidappInfoCompodimo { get; init; }

		[JsonPropertyName("android.appInfo_com.snapchat.android")]
		public string? AndroidappInfoComsnapchatandroid { get; init; }

		[JsonPropertyName("android.appInfo_com.stupeflix.replay")]
		public string? AndroidappInfoComstupeflixreplay { get; init; }

		[JsonPropertyName("android.appInfo_com.tripledot.woodoku")]
		public string? AndroidappInfoComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.appInfo_dk.bilka.app.release")]
		public string? AndroidappInfoDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.appInfo_dk.coop.coopplus")]
		public string? AndroidappInfoDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.appInfo_dk.gls.consigneeapp")]
		public string? AndroidappInfoDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.appInfo_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidappInfoDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.appInfo_io.homeassistant.companion.android")]
		public string? AndroidappInfoIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.bigText_com.facebook.katana")]
		public string? AndroidbigTextComfacebookkatana { get; init; }

		[JsonPropertyName("android.bigText_com.google.android.apps.maps")]
		public string? AndroidbigTextComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.bigText_com.google.android.googlequicksearchbox")]
		public string? AndroidbigTextComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.bigText_com.instagram.android")]
		public string? AndroidbigTextCominstagramandroid { get; init; }

		[JsonPropertyName("android.bigText_com.lunarway.app")]
		public string? AndroidbigTextComlunarwayapp { get; init; }

		[JsonPropertyName("android.bigText_com.microsoft.office.outlook")]
		public string? AndroidbigTextCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.bigText_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidbigTextComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.bigText_com.oculus.twilight")]
		public string? AndroidbigTextComoculustwilight { get; init; }

		[JsonPropertyName("android.bigText_com.snapchat.android")]
		public string? AndroidbigTextComsnapchatandroid { get; init; }

		[JsonPropertyName("android.bigText_com.stupeflix.replay")]
		public string? AndroidbigTextComstupeflixreplay { get; init; }

		[JsonPropertyName("android.bigText_com.tripledot.woodoku")]
		public string? AndroidbigTextComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.bigText_dk.bilka.app.release")]
		public string? AndroidbigTextDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.bigText_dk.coop.coopplus")]
		public string? AndroidbigTextDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.bigText_dk.gls.consigneeapp")]
		public string? AndroidbigTextDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.bigText_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidbigTextDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.bigText_io.homeassistant.companion.android")]
		public string? AndroidbigTextIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.colorized_com.podimo")]
		public bool? AndroidcolorizedCompodimo { get; init; }

		[JsonPropertyName("android.compactActions_com.podimo")]
		public string? AndroidcompactActionsCompodimo { get; init; }

		[JsonPropertyName("android.contains.customView_com.facebook.katana")]
		public bool? AndroidcontainscustomViewComfacebookkatana { get; init; }

		[JsonPropertyName("android.contains.customView_com.pinterest")]
		public bool? AndroidcontainscustomViewCompinterest { get; init; }

		[JsonPropertyName("android.conversationTitle_com.facebook.orca")]
		public string? AndroidconversationTitleComfacebookorca { get; init; }

		[JsonPropertyName("android.conversationUnreadMessageCount_com.facebook.orca")]
		public double? AndroidconversationUnreadMessageCountComfacebookorca { get; init; }

		[JsonPropertyName("android.conversationUnreadMessageCount_com.google.android.dialer")]
		public double? AndroidconversationUnreadMessageCountComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.conversationUnreadMessageCount_com.snapchat.android")]
		public double? AndroidconversationUnreadMessageCountComsnapchatandroid { get; init; }

		[JsonPropertyName("android.hiddenConversationTitle_com.facebook.orca")]
		public string? AndroidhiddenConversationTitleComfacebookorca { get; init; }

		[JsonPropertyName("android.hiddenConversationTitle_com.google.android.dialer")]
		public string? AndroidhiddenConversationTitleComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.infoText_com.android.chrome")]
		public string? AndroidinfoTextComandroidchrome { get; init; }

		[JsonPropertyName("android.infoText_com.facebook.katana")]
		public string? AndroidinfoTextComfacebookkatana { get; init; }

		[JsonPropertyName("android.infoText_com.facebook.orca")]
		public string? AndroidinfoTextComfacebookorca { get; init; }

		[JsonPropertyName("android.infoText_com.google.android.apps.maps")]
		public string? AndroidinfoTextComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.infoText_com.google.android.apps.photos")]
		public string? AndroidinfoTextComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.infoText_com.google.android.dialer")]
		public string? AndroidinfoTextComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.infoText_com.google.android.googlequicksearchbox")]
		public string? AndroidinfoTextComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.infoText_com.instagram.android")]
		public string? AndroidinfoTextCominstagramandroid { get; init; }

		[JsonPropertyName("android.infoText_com.lunarway.app")]
		public string? AndroidinfoTextComlunarwayapp { get; init; }

		[JsonPropertyName("android.infoText_com.microsoft.office.outlook")]
		public string? AndroidinfoTextCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.infoText_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidinfoTextComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.infoText_com.oculus.twilight")]
		public string? AndroidinfoTextComoculustwilight { get; init; }

		[JsonPropertyName("android.infoText_com.pinterest")]
		public string? AndroidinfoTextCompinterest { get; init; }

		[JsonPropertyName("android.infoText_com.podimo")]
		public string? AndroidinfoTextCompodimo { get; init; }

		[JsonPropertyName("android.infoText_com.snapchat.android")]
		public string? AndroidinfoTextComsnapchatandroid { get; init; }

		[JsonPropertyName("android.infoText_com.stupeflix.replay")]
		public string? AndroidinfoTextComstupeflixreplay { get; init; }

		[JsonPropertyName("android.infoText_com.tripledot.woodoku")]
		public string? AndroidinfoTextComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.infoText_dk.bilka.app.release")]
		public string? AndroidinfoTextDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.infoText_dk.coop.coopplus")]
		public string? AndroidinfoTextDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.infoText_dk.gls.consigneeapp")]
		public string? AndroidinfoTextDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.infoText_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidinfoTextDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.infoText_io.homeassistant.companion.android")]
		public string? AndroidinfoTextIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.isGroupConversation_com.facebook.orca")]
		public bool? AndroidisGroupConversationComfacebookorca { get; init; }

		[JsonPropertyName("android.isGroupConversation_com.google.android.dialer")]
		public bool? AndroidisGroupConversationComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.isGroupConversation_com.snapchat.android")]
		public bool? AndroidisGroupConversationComsnapchatandroid { get; init; }

		[JsonPropertyName("android.largeIcon_com.android.chrome")]
		public string? AndroidlargeIconComandroidchrome { get; init; }

		[JsonPropertyName("android.largeIcon_com.facebook.katana")]
		public string? AndroidlargeIconComfacebookkatana { get; init; }

		[JsonPropertyName("android.largeIcon_com.facebook.orca")]
		public string? AndroidlargeIconComfacebookorca { get; init; }

		[JsonPropertyName("android.largeIcon_com.google.android.apps.maps")]
		public string? AndroidlargeIconComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.largeIcon_com.google.android.apps.photos")]
		public string? AndroidlargeIconComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.largeIcon_com.google.android.dialer")]
		public string? AndroidlargeIconComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.largeIcon_com.google.android.googlequicksearchbox")]
		public string? AndroidlargeIconComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.largeIcon_com.instagram.android")]
		public string? AndroidlargeIconCominstagramandroid { get; init; }

		[JsonPropertyName("android.largeIcon_com.lunarway.app")]
		public string? AndroidlargeIconComlunarwayapp { get; init; }

		[JsonPropertyName("android.largeIcon_com.microsoft.office.outlook")]
		public string? AndroidlargeIconCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.largeIcon_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidlargeIconComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.largeIcon_com.oculus.twilight")]
		public string? AndroidlargeIconComoculustwilight { get; init; }

		[JsonPropertyName("android.largeIcon_com.pinterest")]
		public string? AndroidlargeIconCompinterest { get; init; }

		[JsonPropertyName("android.largeIcon_com.podimo")]
		public string? AndroidlargeIconCompodimo { get; init; }

		[JsonPropertyName("android.largeIcon_com.snapchat.android")]
		public string? AndroidlargeIconComsnapchatandroid { get; init; }

		[JsonPropertyName("android.largeIcon_com.stupeflix.replay")]
		public string? AndroidlargeIconComstupeflixreplay { get; init; }

		[JsonPropertyName("android.largeIcon_com.tripledot.woodoku")]
		public string? AndroidlargeIconComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.largeIcon_dk.bilka.app.release")]
		public string? AndroidlargeIconDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.largeIcon_dk.coop.coopplus")]
		public string? AndroidlargeIconDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.largeIcon_dk.gls.consigneeapp")]
		public string? AndroidlargeIconDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.largeIcon_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidlargeIconDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.largeIcon_io.homeassistant.companion.android")]
		public string? AndroidlargeIconIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.mediaSession_com.podimo")]
		public string? AndroidmediaSessionCompodimo { get; init; }

		[JsonPropertyName("android.messages_com.facebook.orca")]
		public string? AndroidmessagesComfacebookorca { get; init; }

		[JsonPropertyName("android.messages_com.google.android.dialer")]
		public string? AndroidmessagesComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.messages_com.snapchat.android")]
		public string? AndroidmessagesComsnapchatandroid { get; init; }

		[JsonPropertyName("android.messagingStyleUser_com.facebook.orca")]
		public string? AndroidmessagingStyleUserComfacebookorca { get; init; }

		[JsonPropertyName("android.messagingStyleUser_com.google.android.dialer")]
		public string? AndroidmessagingStyleUserComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.messagingUser_com.facebook.orca")]
		public string? AndroidmessagingUserComfacebookorca { get; init; }

		[JsonPropertyName("android.messagingUser_com.google.android.dialer")]
		public string? AndroidmessagingUserComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.messagingUser_com.snapchat.android")]
		public string? AndroidmessagingUserComsnapchatandroid { get; init; }

		[JsonPropertyName("android.people.list_com.snapchat.android")]
		public string? AndroidpeoplelistComsnapchatandroid { get; init; }

		[JsonPropertyName("android.picture_com.google.android.apps.photos")]
		public string? AndroidpictureComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.picture_com.netflix.mediaclient")]
		public string? AndroidpictureComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.pictureIcon_com.google.android.apps.photos")]
		public string? AndroidpictureIconComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.pictureIcon_com.netflix.mediaclient")]
		public string? AndroidpictureIconComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.progress_com.android.chrome")]
		public double? AndroidprogressComandroidchrome { get; init; }

		[JsonPropertyName("android.progress_com.facebook.katana")]
		public double? AndroidprogressComfacebookkatana { get; init; }

		[JsonPropertyName("android.progress_com.facebook.orca")]
		public double? AndroidprogressComfacebookorca { get; init; }

		[JsonPropertyName("android.progress_com.google.android.apps.maps")]
		public double? AndroidprogressComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.progress_com.google.android.apps.photos")]
		public double? AndroidprogressComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.progress_com.google.android.dialer")]
		public double? AndroidprogressComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.progress_com.google.android.googlequicksearchbox")]
		public double? AndroidprogressComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.progress_com.instagram.android")]
		public double? AndroidprogressCominstagramandroid { get; init; }

		[JsonPropertyName("android.progress_com.lunarway.app")]
		public double? AndroidprogressComlunarwayapp { get; init; }

		[JsonPropertyName("android.progress_com.microsoft.office.outlook")]
		public double? AndroidprogressCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.progress_com.netcompany.smittestop_exposure_notification")]
		public double? AndroidprogressComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.progress_com.oculus.twilight")]
		public double? AndroidprogressComoculustwilight { get; init; }

		[JsonPropertyName("android.progress_com.pinterest")]
		public double? AndroidprogressCompinterest { get; init; }

		[JsonPropertyName("android.progress_com.podimo")]
		public double? AndroidprogressCompodimo { get; init; }

		[JsonPropertyName("android.progress_com.snapchat.android")]
		public double? AndroidprogressComsnapchatandroid { get; init; }

		[JsonPropertyName("android.progress_com.stupeflix.replay")]
		public double? AndroidprogressComstupeflixreplay { get; init; }

		[JsonPropertyName("android.progress_com.tripledot.woodoku")]
		public double? AndroidprogressComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.progress_dk.bilka.app.release")]
		public double? AndroidprogressDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.progress_dk.coop.coopplus")]
		public double? AndroidprogressDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.progress_dk.gls.consigneeapp")]
		public double? AndroidprogressDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.progress_dk.taenk.mitdigitaleselvforsvar")]
		public double? AndroidprogressDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.android.chrome")]
		public bool? AndroidprogressIndeterminateComandroidchrome { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.facebook.katana")]
		public bool? AndroidprogressIndeterminateComfacebookkatana { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.facebook.orca")]
		public bool? AndroidprogressIndeterminateComfacebookorca { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.google.android.apps.maps")]
		public bool? AndroidprogressIndeterminateComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.google.android.apps.photos")]
		public bool? AndroidprogressIndeterminateComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.google.android.dialer")]
		public bool? AndroidprogressIndeterminateComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.google.android.googlequicksearchbox")]
		public bool? AndroidprogressIndeterminateComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.instagram.android")]
		public bool? AndroidprogressIndeterminateCominstagramandroid { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.lunarway.app")]
		public bool? AndroidprogressIndeterminateComlunarwayapp { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.microsoft.office.outlook")]
		public bool? AndroidprogressIndeterminateCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.netcompany.smittestop_exposure_notification")]
		public bool? AndroidprogressIndeterminateComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.oculus.twilight")]
		public bool? AndroidprogressIndeterminateComoculustwilight { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.pinterest")]
		public bool? AndroidprogressIndeterminateCompinterest { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.podimo")]
		public bool? AndroidprogressIndeterminateCompodimo { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.snapchat.android")]
		public bool? AndroidprogressIndeterminateComsnapchatandroid { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.stupeflix.replay")]
		public bool? AndroidprogressIndeterminateComstupeflixreplay { get; init; }

		[JsonPropertyName("android.progressIndeterminate_com.tripledot.woodoku")]
		public bool? AndroidprogressIndeterminateComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.progressIndeterminate_dk.bilka.app.release")]
		public bool? AndroidprogressIndeterminateDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.progressIndeterminate_dk.coop.coopplus")]
		public bool? AndroidprogressIndeterminateDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.progressIndeterminate_dk.gls.consigneeapp")]
		public bool? AndroidprogressIndeterminateDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.progressIndeterminate_dk.taenk.mitdigitaleselvforsvar")]
		public bool? AndroidprogressIndeterminateDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.progressIndeterminate_io.homeassistant.companion.android")]
		public bool? AndroidprogressIndeterminateIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.progress_io.homeassistant.companion.android")]
		public double? AndroidprogressIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.progressMax_com.android.chrome")]
		public double? AndroidprogressMaxComandroidchrome { get; init; }

		[JsonPropertyName("android.progressMax_com.facebook.katana")]
		public double? AndroidprogressMaxComfacebookkatana { get; init; }

		[JsonPropertyName("android.progressMax_com.facebook.orca")]
		public double? AndroidprogressMaxComfacebookorca { get; init; }

		[JsonPropertyName("android.progressMax_com.google.android.apps.maps")]
		public double? AndroidprogressMaxComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.progressMax_com.google.android.apps.photos")]
		public double? AndroidprogressMaxComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.progressMax_com.google.android.dialer")]
		public double? AndroidprogressMaxComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.progressMax_com.google.android.googlequicksearchbox")]
		public double? AndroidprogressMaxComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.progressMax_com.instagram.android")]
		public double? AndroidprogressMaxCominstagramandroid { get; init; }

		[JsonPropertyName("android.progressMax_com.lunarway.app")]
		public double? AndroidprogressMaxComlunarwayapp { get; init; }

		[JsonPropertyName("android.progressMax_com.microsoft.office.outlook")]
		public double? AndroidprogressMaxCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.progressMax_com.netcompany.smittestop_exposure_notification")]
		public double? AndroidprogressMaxComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.progressMax_com.oculus.twilight")]
		public double? AndroidprogressMaxComoculustwilight { get; init; }

		[JsonPropertyName("android.progressMax_com.pinterest")]
		public double? AndroidprogressMaxCompinterest { get; init; }

		[JsonPropertyName("android.progressMax_com.podimo")]
		public double? AndroidprogressMaxCompodimo { get; init; }

		[JsonPropertyName("android.progressMax_com.snapchat.android")]
		public double? AndroidprogressMaxComsnapchatandroid { get; init; }

		[JsonPropertyName("android.progressMax_com.stupeflix.replay")]
		public double? AndroidprogressMaxComstupeflixreplay { get; init; }

		[JsonPropertyName("android.progressMax_com.tripledot.woodoku")]
		public double? AndroidprogressMaxComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.progressMax_dk.bilka.app.release")]
		public double? AndroidprogressMaxDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.progressMax_dk.coop.coopplus")]
		public double? AndroidprogressMaxDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.progressMax_dk.gls.consigneeapp")]
		public double? AndroidprogressMaxDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.progressMax_dk.taenk.mitdigitaleselvforsvar")]
		public double? AndroidprogressMaxDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.progressMax_io.homeassistant.companion.android")]
		public double? AndroidprogressMaxIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.reduced.images_com.android.chrome")]
		public bool? AndroidreducedimagesComandroidchrome { get; init; }

		[JsonPropertyName("android.reduced.images_com.android.providers.downloads")]
		public bool? AndroidreducedimagesComandroidprovidersdownloads { get; init; }

		[JsonPropertyName("android.reduced.images_com.facebook.katana")]
		public bool? AndroidreducedimagesComfacebookkatana { get; init; }

		[JsonPropertyName("android.reduced.images_com.facebook.orca")]
		public bool? AndroidreducedimagesComfacebookorca { get; init; }

		[JsonPropertyName("android.reduced.images_com.google.android.apps.maps")]
		public bool? AndroidreducedimagesComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.reduced.images_com.google.android.apps.photos")]
		public bool? AndroidreducedimagesComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.reduced.images_com.google.android.dialer")]
		public bool? AndroidreducedimagesComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.reduced.images_com.google.android.googlequicksearchbox")]
		public bool? AndroidreducedimagesComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.reduced.images_com.instagram.android")]
		public bool? AndroidreducedimagesCominstagramandroid { get; init; }

		[JsonPropertyName("android.reduced.images_com.lunarway.app")]
		public bool? AndroidreducedimagesComlunarwayapp { get; init; }

		[JsonPropertyName("android.reduced.images_com.microsoft.office.outlook")]
		public bool? AndroidreducedimagesCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.reduced.images_com.netcompany.smittestop_exposure_notification")]
		public bool? AndroidreducedimagesComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.reduced.images_com.netflix.mediaclient")]
		public bool? AndroidreducedimagesComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.reduced.images_com.oculus.twilight")]
		public bool? AndroidreducedimagesComoculustwilight { get; init; }

		[JsonPropertyName("android.reduced.images_com.pinterest")]
		public bool? AndroidreducedimagesCompinterest { get; init; }

		[JsonPropertyName("android.reduced.images_com.podimo")]
		public bool? AndroidreducedimagesCompodimo { get; init; }

		[JsonPropertyName("android.reduced.images_com.snapchat.android")]
		public bool? AndroidreducedimagesComsnapchatandroid { get; init; }

		[JsonPropertyName("android.reduced.images_com.stupeflix.replay")]
		public bool? AndroidreducedimagesComstupeflixreplay { get; init; }

		[JsonPropertyName("android.reduced.images_com.tripledot.woodoku")]
		public bool? AndroidreducedimagesComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.reduced.images_dk.bilka.app.release")]
		public bool? AndroidreducedimagesDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.reduced.images_dk.coop.coopplus")]
		public bool? AndroidreducedimagesDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.reduced.images_dk.gls.consigneeapp")]
		public bool? AndroidreducedimagesDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.reduced.images_dk.taenk.mitdigitaleselvforsvar")]
		public bool? AndroidreducedimagesDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.reduced.images_io.homeassistant.companion.android")]
		public bool? AndroidreducedimagesIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.android.chrome")]
		public string? AndroidremoteInputHistoryComandroidchrome { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.facebook.katana")]
		public string? AndroidremoteInputHistoryComfacebookkatana { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.facebook.orca")]
		public string? AndroidremoteInputHistoryComfacebookorca { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.google.android.apps.maps")]
		public string? AndroidremoteInputHistoryComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.google.android.apps.photos")]
		public string? AndroidremoteInputHistoryComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.google.android.dialer")]
		public string? AndroidremoteInputHistoryComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.google.android.googlequicksearchbox")]
		public string? AndroidremoteInputHistoryComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.instagram.android")]
		public string? AndroidremoteInputHistoryCominstagramandroid { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.lunarway.app")]
		public string? AndroidremoteInputHistoryComlunarwayapp { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.microsoft.office.outlook")]
		public string? AndroidremoteInputHistoryCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidremoteInputHistoryComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.oculus.twilight")]
		public string? AndroidremoteInputHistoryComoculustwilight { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.pinterest")]
		public string? AndroidremoteInputHistoryCompinterest { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.podimo")]
		public string? AndroidremoteInputHistoryCompodimo { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.snapchat.android")]
		public string? AndroidremoteInputHistoryComsnapchatandroid { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.stupeflix.replay")]
		public string? AndroidremoteInputHistoryComstupeflixreplay { get; init; }

		[JsonPropertyName("android.remoteInputHistory_com.tripledot.woodoku")]
		public string? AndroidremoteInputHistoryComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.remoteInputHistory_dk.bilka.app.release")]
		public string? AndroidremoteInputHistoryDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.remoteInputHistory_dk.coop.coopplus")]
		public string? AndroidremoteInputHistoryDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.remoteInputHistory_dk.gls.consigneeapp")]
		public string? AndroidremoteInputHistoryDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.remoteInputHistory_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidremoteInputHistoryDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.remoteInputHistory_io.homeassistant.companion.android")]
		public string? AndroidremoteInputHistoryIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.selfDisplayName_com.facebook.orca")]
		public string? AndroidselfDisplayNameComfacebookorca { get; init; }

		[JsonPropertyName("android.selfDisplayName_com.google.android.dialer")]
		public string? AndroidselfDisplayNameComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.selfDisplayName_com.snapchat.android")]
		public string? AndroidselfDisplayNameComsnapchatandroid { get; init; }

		[JsonPropertyName("android.showBigPictureWhenCollapsed_com.google.android.apps.photos")]
		public bool? AndroidshowBigPictureWhenCollapsedComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.showBigPictureWhenCollapsed_com.netflix.mediaclient")]
		public bool? AndroidshowBigPictureWhenCollapsedComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.showChronometer_com.android.chrome")]
		public bool? AndroidshowChronometerComandroidchrome { get; init; }

		[JsonPropertyName("android.showChronometer_com.facebook.katana")]
		public bool? AndroidshowChronometerComfacebookkatana { get; init; }

		[JsonPropertyName("android.showChronometer_com.facebook.orca")]
		public bool? AndroidshowChronometerComfacebookorca { get; init; }

		[JsonPropertyName("android.showChronometer_com.google.android.apps.maps")]
		public bool? AndroidshowChronometerComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.showChronometer_com.google.android.apps.photos")]
		public bool? AndroidshowChronometerComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.showChronometer_com.google.android.dialer")]
		public bool? AndroidshowChronometerComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.showChronometer_com.google.android.googlequicksearchbox")]
		public bool? AndroidshowChronometerComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.showChronometer_com.instagram.android")]
		public bool? AndroidshowChronometerCominstagramandroid { get; init; }

		[JsonPropertyName("android.showChronometer_com.lunarway.app")]
		public bool? AndroidshowChronometerComlunarwayapp { get; init; }

		[JsonPropertyName("android.showChronometer_com.microsoft.office.outlook")]
		public bool? AndroidshowChronometerCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.showChronometer_com.netcompany.smittestop_exposure_notification")]
		public bool? AndroidshowChronometerComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.showChronometer_com.oculus.twilight")]
		public bool? AndroidshowChronometerComoculustwilight { get; init; }

		[JsonPropertyName("android.showChronometer_com.pinterest")]
		public bool? AndroidshowChronometerCompinterest { get; init; }

		[JsonPropertyName("android.showChronometer_com.podimo")]
		public bool? AndroidshowChronometerCompodimo { get; init; }

		[JsonPropertyName("android.showChronometer_com.snapchat.android")]
		public bool? AndroidshowChronometerComsnapchatandroid { get; init; }

		[JsonPropertyName("android.showChronometer_com.stupeflix.replay")]
		public bool? AndroidshowChronometerComstupeflixreplay { get; init; }

		[JsonPropertyName("android.showChronometer_com.tripledot.woodoku")]
		public bool? AndroidshowChronometerComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.showChronometer_dk.bilka.app.release")]
		public bool? AndroidshowChronometerDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.showChronometer_dk.coop.coopplus")]
		public bool? AndroidshowChronometerDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.showChronometer_dk.gls.consigneeapp")]
		public bool? AndroidshowChronometerDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.showChronometer_dk.taenk.mitdigitaleselvforsvar")]
		public bool? AndroidshowChronometerDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.showChronometer_io.homeassistant.companion.android")]
		public bool? AndroidshowChronometerIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.showWhen_com.android.chrome")]
		public bool? AndroidshowWhenComandroidchrome { get; init; }

		[JsonPropertyName("android.showWhen_com.facebook.katana")]
		public bool? AndroidshowWhenComfacebookkatana { get; init; }

		[JsonPropertyName("android.showWhen_com.facebook.orca")]
		public bool? AndroidshowWhenComfacebookorca { get; init; }

		[JsonPropertyName("android.showWhen_com.google.android.apps.maps")]
		public bool? AndroidshowWhenComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.showWhen_com.google.android.apps.photos")]
		public bool? AndroidshowWhenComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.showWhen_com.google.android.dialer")]
		public bool? AndroidshowWhenComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.showWhen_com.google.android.googlequicksearchbox")]
		public bool? AndroidshowWhenComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.showWhen_com.instagram.android")]
		public bool? AndroidshowWhenCominstagramandroid { get; init; }

		[JsonPropertyName("android.showWhen_com.lunarway.app")]
		public bool? AndroidshowWhenComlunarwayapp { get; init; }

		[JsonPropertyName("android.showWhen_com.microsoft.office.outlook")]
		public bool? AndroidshowWhenCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.showWhen_com.netcompany.smittestop_exposure_notification")]
		public bool? AndroidshowWhenComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.showWhen_com.oculus.twilight")]
		public bool? AndroidshowWhenComoculustwilight { get; init; }

		[JsonPropertyName("android.showWhen_com.pinterest")]
		public bool? AndroidshowWhenCompinterest { get; init; }

		[JsonPropertyName("android.showWhen_com.podimo")]
		public bool? AndroidshowWhenCompodimo { get; init; }

		[JsonPropertyName("android.showWhen_com.snapchat.android")]
		public bool? AndroidshowWhenComsnapchatandroid { get; init; }

		[JsonPropertyName("android.showWhen_com.stupeflix.replay")]
		public bool? AndroidshowWhenComstupeflixreplay { get; init; }

		[JsonPropertyName("android.showWhen_com.tripledot.woodoku")]
		public bool? AndroidshowWhenComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.showWhen_dk.bilka.app.release")]
		public bool? AndroidshowWhenDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.showWhen_dk.coop.coopplus")]
		public bool? AndroidshowWhenDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.showWhen_dk.gls.consigneeapp")]
		public bool? AndroidshowWhenDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.showWhen_dk.taenk.mitdigitaleselvforsvar")]
		public bool? AndroidshowWhenDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.showWhen_io.homeassistant.companion.android")]
		public bool? AndroidshowWhenIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.subText_com.android.chrome")]
		public string? AndroidsubTextComandroidchrome { get; init; }

		[JsonPropertyName("android.subText_com.facebook.katana")]
		public string? AndroidsubTextComfacebookkatana { get; init; }

		[JsonPropertyName("android.subText_com.facebook.orca")]
		public string? AndroidsubTextComfacebookorca { get; init; }

		[JsonPropertyName("android.subText_com.google.android.apps.maps")]
		public string? AndroidsubTextComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.subText_com.google.android.apps.photos")]
		public string? AndroidsubTextComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.subText_com.google.android.dialer")]
		public string? AndroidsubTextComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.subText_com.google.android.googlequicksearchbox")]
		public string? AndroidsubTextComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.subText_com.instagram.android")]
		public string? AndroidsubTextCominstagramandroid { get; init; }

		[JsonPropertyName("android.subText_com.lunarway.app")]
		public string? AndroidsubTextComlunarwayapp { get; init; }

		[JsonPropertyName("android.subText_com.microsoft.office.outlook")]
		public string? AndroidsubTextCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.subText_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidsubTextComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.subText_com.netflix.mediaclient")]
		public string? AndroidsubTextComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.subText_com.oculus.twilight")]
		public string? AndroidsubTextComoculustwilight { get; init; }

		[JsonPropertyName("android.subText_com.pinterest")]
		public string? AndroidsubTextCompinterest { get; init; }

		[JsonPropertyName("android.subText_com.podimo")]
		public string? AndroidsubTextCompodimo { get; init; }

		[JsonPropertyName("android.subText_com.snapchat.android")]
		public string? AndroidsubTextComsnapchatandroid { get; init; }

		[JsonPropertyName("android.subText_com.stupeflix.replay")]
		public string? AndroidsubTextComstupeflixreplay { get; init; }

		[JsonPropertyName("android.subText_com.tripledot.woodoku")]
		public string? AndroidsubTextComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.subText_dk.bilka.app.release")]
		public string? AndroidsubTextDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.subText_dk.coop.coopplus")]
		public string? AndroidsubTextDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.subText_dk.gls.consigneeapp")]
		public string? AndroidsubTextDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.subText_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidsubTextDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.subText_io.homeassistant.companion.android")]
		public string? AndroidsubTextIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.summaryText_com.microsoft.office.outlook")]
		public string? AndroidsummaryTextCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.summaryText_com.netflix.mediaclient")]
		public string? AndroidsummaryTextComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.support.v4.app.extra.COMPAT_TEMPLATE_com.google.android.apps.maps")]
		public string? Androidsupportv4appextraCOMPATTEMPLATEComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.support.v4.app.extra.COMPAT_TEMPLATE_com.google.android.apps.photos")]
		public string? Androidsupportv4appextraCOMPATTEMPLATEComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.support.v4.app.extra.COMPAT_TEMPLATE_com.google.android.dialer")]
		public string? Androidsupportv4appextraCOMPATTEMPLATEComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.support.v4.app.extra.COMPAT_TEMPLATE_com.google.android.googlequicksearchbox")]
		public string? Androidsupportv4appextraCOMPATTEMPLATEComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.template_com.facebook.katana")]
		public string? AndroidtemplateComfacebookkatana { get; init; }

		[JsonPropertyName("android.template_com.facebook.orca")]
		public string? AndroidtemplateComfacebookorca { get; init; }

		[JsonPropertyName("android.template_com.google.android.apps.maps")]
		public string? AndroidtemplateComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.template_com.google.android.apps.photos")]
		public string? AndroidtemplateComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.template_com.google.android.dialer")]
		public string? AndroidtemplateComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.template_com.google.android.googlequicksearchbox")]
		public string? AndroidtemplateComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.template_com.instagram.android")]
		public string? AndroidtemplateCominstagramandroid { get; init; }

		[JsonPropertyName("android.template_com.lunarway.app")]
		public string? AndroidtemplateComlunarwayapp { get; init; }

		[JsonPropertyName("android.template_com.microsoft.office.outlook")]
		public string? AndroidtemplateCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.template_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidtemplateComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.template_com.netflix.mediaclient")]
		public string? AndroidtemplateComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.template_com.oculus.twilight")]
		public string? AndroidtemplateComoculustwilight { get; init; }

		[JsonPropertyName("android.template_com.pinterest")]
		public string? AndroidtemplateCompinterest { get; init; }

		[JsonPropertyName("android.template_com.podimo")]
		public string? AndroidtemplateCompodimo { get; init; }

		[JsonPropertyName("android.template_com.snapchat.android")]
		public string? AndroidtemplateComsnapchatandroid { get; init; }

		[JsonPropertyName("android.template_com.stupeflix.replay")]
		public string? AndroidtemplateComstupeflixreplay { get; init; }

		[JsonPropertyName("android.template_com.tripledot.woodoku")]
		public string? AndroidtemplateComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.template_dk.bilka.app.release")]
		public string? AndroidtemplateDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.template_dk.coop.coopplus")]
		public string? AndroidtemplateDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.template_dk.gls.consigneeapp")]
		public string? AndroidtemplateDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.template_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidtemplateDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.template_io.homeassistant.companion.android")]
		public string? AndroidtemplateIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.text_com.android.chrome")]
		public string? AndroidtextComandroidchrome { get; init; }

		[JsonPropertyName("android.text_com.android.providers.downloads")]
		public string? AndroidtextComandroidprovidersdownloads { get; init; }

		[JsonPropertyName("android.text_com.facebook.katana")]
		public string? AndroidtextComfacebookkatana { get; init; }

		[JsonPropertyName("android.text_com.facebook.orca")]
		public string? AndroidtextComfacebookorca { get; init; }

		[JsonPropertyName("android.text_com.google.android.apps.maps")]
		public string? AndroidtextComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.text_com.google.android.apps.photos")]
		public string? AndroidtextComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.text_com.google.android.dialer")]
		public string? AndroidtextComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.text_com.google.android.googlequicksearchbox")]
		public string? AndroidtextComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.text_com.instagram.android")]
		public string? AndroidtextCominstagramandroid { get; init; }

		[JsonPropertyName("android.text_com.lunarway.app")]
		public string? AndroidtextComlunarwayapp { get; init; }

		[JsonPropertyName("android.text_com.microsoft.office.outlook")]
		public string? AndroidtextCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.text_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidtextComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.text_com.netflix.mediaclient")]
		public string? AndroidtextComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.text_com.oculus.twilight")]
		public string? AndroidtextComoculustwilight { get; init; }

		[JsonPropertyName("android.text_com.pinterest")]
		public string? AndroidtextCompinterest { get; init; }

		[JsonPropertyName("android.text_com.podimo")]
		public string? AndroidtextCompodimo { get; init; }

		[JsonPropertyName("android.text_com.snapchat.android")]
		public string? AndroidtextComsnapchatandroid { get; init; }

		[JsonPropertyName("android.text_com.stupeflix.replay")]
		public string? AndroidtextComstupeflixreplay { get; init; }

		[JsonPropertyName("android.text_com.tripledot.woodoku")]
		public string? AndroidtextComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.text_dk.bilka.app.release")]
		public string? AndroidtextDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.text_dk.coop.coopplus")]
		public string? AndroidtextDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.text_dk.gls.consigneeapp")]
		public string? AndroidtextDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.text_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidtextDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.text_io.homeassistant.companion.android")]
		public string? AndroidtextIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.textLines_com.microsoft.office.outlook")]
		public string? AndroidtextLinesCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.title.big_com.google.android.apps.maps")]
		public string? AndroidtitlebigComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.title.big_com.google.android.apps.photos")]
		public string? AndroidtitlebigComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.title.big_com.microsoft.office.outlook")]
		public string? AndroidtitlebigCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.title_com.android.chrome")]
		public string? AndroidtitleComandroidchrome { get; init; }

		[JsonPropertyName("android.title_com.android.providers.downloads")]
		public string? AndroidtitleComandroidprovidersdownloads { get; init; }

		[JsonPropertyName("android.title_com.facebook.katana")]
		public string? AndroidtitleComfacebookkatana { get; init; }

		[JsonPropertyName("android.title_com.facebook.orca")]
		public string? AndroidtitleComfacebookorca { get; init; }

		[JsonPropertyName("android.title_com.google.android.apps.maps")]
		public string? AndroidtitleComgoogleandroidappsmaps { get; init; }

		[JsonPropertyName("android.title_com.google.android.apps.photos")]
		public string? AndroidtitleComgoogleandroidappsphotos { get; init; }

		[JsonPropertyName("android.title_com.google.android.dialer")]
		public string? AndroidtitleComgoogleandroiddialer { get; init; }

		[JsonPropertyName("android.title_com.google.android.googlequicksearchbox")]
		public string? AndroidtitleComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("android.title_com.instagram.android")]
		public string? AndroidtitleCominstagramandroid { get; init; }

		[JsonPropertyName("android.title_com.lunarway.app")]
		public string? AndroidtitleComlunarwayapp { get; init; }

		[JsonPropertyName("android.title_com.microsoft.office.outlook")]
		public string? AndroidtitleCommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("android.title_com.netcompany.smittestop_exposure_notification")]
		public string? AndroidtitleComnetcompanysmittestopExposureNotification { get; init; }

		[JsonPropertyName("android.title_com.netflix.mediaclient")]
		public string? AndroidtitleComnetflixmediaclient { get; init; }

		[JsonPropertyName("android.title_com.oculus.twilight")]
		public string? AndroidtitleComoculustwilight { get; init; }

		[JsonPropertyName("android.title_com.pinterest")]
		public string? AndroidtitleCompinterest { get; init; }

		[JsonPropertyName("android.title_com.podimo")]
		public string? AndroidtitleCompodimo { get; init; }

		[JsonPropertyName("android.title_com.snapchat.android")]
		public string? AndroidtitleComsnapchatandroid { get; init; }

		[JsonPropertyName("android.title_com.stupeflix.replay")]
		public string? AndroidtitleComstupeflixreplay { get; init; }

		[JsonPropertyName("android.title_com.tripledot.woodoku")]
		public string? AndroidtitleComtripledotwoodoku { get; init; }

		[JsonPropertyName("android.title_dk.bilka.app.release")]
		public string? AndroidtitleDkbilkaapprelease { get; init; }

		[JsonPropertyName("android.title_dk.coop.coopplus")]
		public string? AndroidtitleDkcoopcoopplus { get; init; }

		[JsonPropertyName("android.title_dk.gls.consigneeapp")]
		public string? AndroidtitleDkglsconsigneeapp { get; init; }

		[JsonPropertyName("android.title_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidtitleDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("android.title_io.homeassistant.companion.android")]
		public string? AndroidtitleIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("android.wearable.EXTENSIONS_com.facebook.orca")]
		public string? AndroidwearableEXTENSIONSComfacebookorca { get; init; }

		[JsonPropertyName("android.wearable.EXTENSIONS_com.snapchat.android")]
		public string? AndroidwearableEXTENSIONSComsnapchatandroid { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.facebook.katana")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEComfacebookkatana { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.facebook.orca")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEComfacebookorca { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.instagram.android")]
		public string? AndroidxcoreappextraCOMPATTEMPLATECominstagramandroid { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.lunarway.app")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEComlunarwayapp { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.microsoft.office.outlook")]
		public string? AndroidxcoreappextraCOMPATTEMPLATECommicrosoftofficeoutlook { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.oculus.twilight")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEComoculustwilight { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.pinterest")]
		public string? AndroidxcoreappextraCOMPATTEMPLATECompinterest { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.snapchat.android")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEComsnapchatandroid { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_com.tripledot.woodoku")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEComtripledotwoodoku { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_dk.coop.coopplus")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEDkcoopcoopplus { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_dk.gls.consigneeapp")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEDkglsconsigneeapp { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_dk.taenk.mitdigitaleselvforsvar")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEDktaenkmitdigitaleselvforsvar { get; init; }

		[JsonPropertyName("androidx.core.app.extra.COMPAT_TEMPLATE_io.homeassistant.companion.android")]
		public string? AndroidxcoreappextraCOMPATTEMPLATEIohomeassistantcompanionandroid { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery_quantity")]
		public double? BatteryQuantity { get; init; }

		[JsonPropertyName("battery_size")]
		public string? BatterySize { get; init; }

		[JsonPropertyName("battery_voltage")]
		public double? BatteryVoltage { get; init; }

		[JsonPropertyName("Chrome.NotificationBundleIconIdExtra_com.android.chrome")]
		public double? ChromeNotificationBundleIconIdExtraComandroidchrome { get; init; }

		[JsonPropertyName("com.android.chrome_1000093_is_clearable")]
		public bool? Comandroidchrome1000093IsClearable { get; init; }

		[JsonPropertyName("com.android.chrome_1000093_is_ongoing")]
		public bool? Comandroidchrome1000093IsOngoing { get; init; }

		[JsonPropertyName("com.android.chrome_1000093_post_time")]
		public double? Comandroidchrome1000093PostTime { get; init; }

		[JsonPropertyName("com.android.chrome_1000094_is_clearable")]
		public bool? Comandroidchrome1000094IsClearable { get; init; }

		[JsonPropertyName("com.android.chrome_1000094_is_ongoing")]
		public bool? Comandroidchrome1000094IsOngoing { get; init; }

		[JsonPropertyName("com.android.chrome_1000094_post_time")]
		public double? Comandroidchrome1000094PostTime { get; init; }

		[JsonPropertyName("com.android.chrome_1000095_is_clearable")]
		public bool? Comandroidchrome1000095IsClearable { get; init; }

		[JsonPropertyName("com.android.chrome_1000095_is_ongoing")]
		public bool? Comandroidchrome1000095IsOngoing { get; init; }

		[JsonPropertyName("com.android.chrome_1000095_post_time")]
		public double? Comandroidchrome1000095PostTime { get; init; }

		[JsonPropertyName("com.android.chrome_1000096_is_clearable")]
		public bool? Comandroidchrome1000096IsClearable { get; init; }

		[JsonPropertyName("com.android.chrome_1000096_is_ongoing")]
		public bool? Comandroidchrome1000096IsOngoing { get; init; }

		[JsonPropertyName("com.android.chrome_1000096_post_time")]
		public double? Comandroidchrome1000096PostTime { get; init; }

		[JsonPropertyName("com.android.chrome_1000097_is_clearable")]
		public bool? Comandroidchrome1000097IsClearable { get; init; }

		[JsonPropertyName("com.android.chrome_1000097_is_ongoing")]
		public bool? Comandroidchrome1000097IsOngoing { get; init; }

		[JsonPropertyName("com.android.chrome_1000097_post_time")]
		public double? Comandroidchrome1000097PostTime { get; init; }

		[JsonPropertyName("com.android.providers.downloads_0_is_clearable")]
		public bool? Comandroidprovidersdownloads0IsClearable { get; init; }

		[JsonPropertyName("com.android.providers.downloads_0_is_ongoing")]
		public bool? Comandroidprovidersdownloads0IsOngoing { get; init; }

		[JsonPropertyName("com.android.providers.downloads_0_post_time")]
		public double? Comandroidprovidersdownloads0PostTime { get; init; }

		[JsonPropertyName("com.facebook.katana_0_is_clearable")]
		public bool? Comfacebookkatana0IsClearable { get; init; }

		[JsonPropertyName("com.facebook.katana_0_is_ongoing")]
		public bool? Comfacebookkatana0IsOngoing { get; init; }

		[JsonPropertyName("com.facebook.katana_0_post_time")]
		public double? Comfacebookkatana0PostTime { get; init; }

		[JsonPropertyName("com.facebook.orca_10000_is_clearable")]
		public bool? Comfacebookorca10000IsClearable { get; init; }

		[JsonPropertyName("com.facebook.orca_10000_is_ongoing")]
		public bool? Comfacebookorca10000IsOngoing { get; init; }

		[JsonPropertyName("com.facebook.orca_10000_post_time")]
		public double? Comfacebookorca10000PostTime { get; init; }

		[JsonPropertyName("com.facebook.orca_2147483647_is_clearable")]
		public bool? Comfacebookorca2147483647IsClearable { get; init; }

		[JsonPropertyName("com.facebook.orca_2147483647_is_ongoing")]
		public bool? Comfacebookorca2147483647IsOngoing { get; init; }

		[JsonPropertyName("com.facebook.orca_2147483647_post_time")]
		public double? Comfacebookorca2147483647PostTime { get; init; }

		[JsonPropertyName("com.google.android.apps.maps_0_is_clearable")]
		public bool? Comgoogleandroidappsmaps0IsClearable { get; init; }

		[JsonPropertyName("com.google.android.apps.maps_0_is_ongoing")]
		public bool? Comgoogleandroidappsmaps0IsOngoing { get; init; }

		[JsonPropertyName("com.google.android.apps.maps_0_post_time")]
		public double? Comgoogleandroidappsmaps0PostTime { get; init; }

		[JsonPropertyName("com.google.android.apps.photos_0_is_clearable")]
		public bool? Comgoogleandroidappsphotos0IsClearable { get; init; }

		[JsonPropertyName("com.google.android.apps.photos_0_is_ongoing")]
		public bool? Comgoogleandroidappsphotos0IsOngoing { get; init; }

		[JsonPropertyName("com.google.android.apps.photos_0_post_time")]
		public double? Comgoogleandroidappsphotos0PostTime { get; init; }

		[JsonPropertyName("com.google.android.dialer_1_is_clearable")]
		public bool? Comgoogleandroiddialer1IsClearable { get; init; }

		[JsonPropertyName("com.google.android.dialer_1_is_ongoing")]
		public bool? Comgoogleandroiddialer1IsOngoing { get; init; }

		[JsonPropertyName("com.google.android.dialer_1_post_time")]
		public double? Comgoogleandroiddialer1PostTime { get; init; }

		[JsonPropertyName("com.google.android.googlequicksearchbox_-1438148997_is_clearable")]
		public bool? Comgoogleandroidgooglequicksearchbox1438148997IsClearable { get; init; }

		[JsonPropertyName("com.google.android.googlequicksearchbox_-1438148997_is_ongoing")]
		public bool? Comgoogleandroidgooglequicksearchbox1438148997IsOngoing { get; init; }

		[JsonPropertyName("com.google.android.googlequicksearchbox_-1438148997_post_time")]
		public double? Comgoogleandroidgooglequicksearchbox1438148997PostTime { get; init; }

		[JsonPropertyName("com.instagram.android_64278_is_clearable")]
		public bool? Cominstagramandroid64278IsClearable { get; init; }

		[JsonPropertyName("com.instagram.android_64278_is_ongoing")]
		public bool? Cominstagramandroid64278IsOngoing { get; init; }

		[JsonPropertyName("com.instagram.android_64278_post_time")]
		public double? Cominstagramandroid64278PostTime { get; init; }

		[JsonPropertyName("com.lunarway.app_-1218823471_is_clearable")]
		public bool? Comlunarwayapp1218823471IsClearable { get; init; }

		[JsonPropertyName("com.lunarway.app_-1218823471_is_ongoing")]
		public bool? Comlunarwayapp1218823471IsOngoing { get; init; }

		[JsonPropertyName("com.lunarway.app_-1218823471_post_time")]
		public double? Comlunarwayapp1218823471PostTime { get; init; }

		[JsonPropertyName("com.microsoft.office.outlook_1_is_clearable")]
		public bool? Commicrosoftofficeoutlook1IsClearable { get; init; }

		[JsonPropertyName("com.microsoft.office.outlook_1_is_ongoing")]
		public bool? Commicrosoftofficeoutlook1IsOngoing { get; init; }

		[JsonPropertyName("com.microsoft.office.outlook_1_post_time")]
		public double? Commicrosoftofficeoutlook1PostTime { get; init; }

		[JsonPropertyName("com.microsoft.office.outlook_2_is_clearable")]
		public bool? Commicrosoftofficeoutlook2IsClearable { get; init; }

		[JsonPropertyName("com.microsoft.office.outlook_2_is_ongoing")]
		public bool? Commicrosoftofficeoutlook2IsOngoing { get; init; }

		[JsonPropertyName("com.microsoft.office.outlook_2_post_time")]
		public double? Commicrosoftofficeoutlook2PostTime { get; init; }

		[JsonPropertyName("com.netcompany.smittestop_exposure_notification_5_is_clearable")]
		public bool? ComnetcompanysmittestopExposureNotification5IsClearable { get; init; }

		[JsonPropertyName("com.netcompany.smittestop_exposure_notification_5_is_ongoing")]
		public bool? ComnetcompanysmittestopExposureNotification5IsOngoing { get; init; }

		[JsonPropertyName("com.netcompany.smittestop_exposure_notification_5_post_time")]
		public double? ComnetcompanysmittestopExposureNotification5PostTime { get; init; }

		[JsonPropertyName("com.netflix.mediaclient_42_is_clearable")]
		public bool? Comnetflixmediaclient42IsClearable { get; init; }

		[JsonPropertyName("com.netflix.mediaclient_42_is_ongoing")]
		public bool? Comnetflixmediaclient42IsOngoing { get; init; }

		[JsonPropertyName("com.netflix.mediaclient_42_post_time")]
		public double? Comnetflixmediaclient42PostTime { get; init; }

		[JsonPropertyName("com.oculus.twilight_10_is_clearable")]
		public bool? Comoculustwilight10IsClearable { get; init; }

		[JsonPropertyName("com.oculus.twilight_10_is_ongoing")]
		public bool? Comoculustwilight10IsOngoing { get; init; }

		[JsonPropertyName("com.oculus.twilight_10_post_time")]
		public double? Comoculustwilight10PostTime { get; init; }

		[JsonPropertyName("com.pinterest_-1985303206_is_clearable")]
		public bool? Compinterest1985303206IsClearable { get; init; }

		[JsonPropertyName("com.pinterest_-1985303206_is_ongoing")]
		public bool? Compinterest1985303206IsOngoing { get; init; }

		[JsonPropertyName("com.pinterest_-1985303206_post_time")]
		public double? Compinterest1985303206PostTime { get; init; }

		[JsonPropertyName("com.podimo_412_is_clearable")]
		public bool? Compodimo412IsClearable { get; init; }

		[JsonPropertyName("com.podimo_412_is_ongoing")]
		public bool? Compodimo412IsOngoing { get; init; }

		[JsonPropertyName("com.podimo_412_post_time")]
		public double? Compodimo412PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_1070793219_is_clearable")]
		public bool? Comsnapchatandroid1070793219IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_1070793219_is_ongoing")]
		public bool? Comsnapchatandroid1070793219IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_1070793219_post_time")]
		public double? Comsnapchatandroid1070793219PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_-1695735583_is_clearable")]
		public bool? Comsnapchatandroid1695735583IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_-1695735583_is_ongoing")]
		public bool? Comsnapchatandroid1695735583IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_-1695735583_post_time")]
		public double? Comsnapchatandroid1695735583PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_181495953_is_clearable")]
		public bool? Comsnapchatandroid181495953IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_181495953_is_ongoing")]
		public bool? Comsnapchatandroid181495953IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_181495953_post_time")]
		public double? Comsnapchatandroid181495953PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_1958544441_is_clearable")]
		public bool? Comsnapchatandroid1958544441IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_1958544441_is_ongoing")]
		public bool? Comsnapchatandroid1958544441IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_1958544441_post_time")]
		public double? Comsnapchatandroid1958544441PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_-29004762_is_clearable")]
		public bool? Comsnapchatandroid29004762IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_-29004762_is_ongoing")]
		public bool? Comsnapchatandroid29004762IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_-29004762_post_time")]
		public double? Comsnapchatandroid29004762PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_480251491_is_clearable")]
		public bool? Comsnapchatandroid480251491IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_480251491_is_ongoing")]
		public bool? Comsnapchatandroid480251491IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_480251491_post_time")]
		public double? Comsnapchatandroid480251491PostTime { get; init; }

		[JsonPropertyName("com.snapchat.android_-73000028_is_clearable")]
		public bool? Comsnapchatandroid73000028IsClearable { get; init; }

		[JsonPropertyName("com.snapchat.android_-73000028_is_ongoing")]
		public bool? Comsnapchatandroid73000028IsOngoing { get; init; }

		[JsonPropertyName("com.snapchat.android_-73000028_post_time")]
		public double? Comsnapchatandroid73000028PostTime { get; init; }

		[JsonPropertyName("com.stupeflix.replay_1350192_is_clearable")]
		public bool? Comstupeflixreplay1350192IsClearable { get; init; }

		[JsonPropertyName("com.stupeflix.replay_1350192_is_ongoing")]
		public bool? Comstupeflixreplay1350192IsOngoing { get; init; }

		[JsonPropertyName("com.stupeflix.replay_1350192_post_time")]
		public double? Comstupeflixreplay1350192PostTime { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_1137709548_is_clearable")]
		public bool? Comtripledotwoodoku1137709548IsClearable { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_1137709548_is_ongoing")]
		public bool? Comtripledotwoodoku1137709548IsOngoing { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_1137709548_post_time")]
		public double? Comtripledotwoodoku1137709548PostTime { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_1412446498_is_clearable")]
		public bool? Comtripledotwoodoku1412446498IsClearable { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_1412446498_is_ongoing")]
		public bool? Comtripledotwoodoku1412446498IsOngoing { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_1412446498_post_time")]
		public double? Comtripledotwoodoku1412446498PostTime { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_-2032596160_is_clearable")]
		public bool? Comtripledotwoodoku2032596160IsClearable { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_-2032596160_is_ongoing")]
		public bool? Comtripledotwoodoku2032596160IsOngoing { get; init; }

		[JsonPropertyName("com.tripledot.woodoku_-2032596160_post_time")]
		public double? Comtripledotwoodoku2032596160PostTime { get; init; }

		[JsonPropertyName("connected_not_paired_devices")]
		public string? ConnectedNotPairedDevices { get; init; }

		[JsonPropertyName("connected_paired_devices")]
		public string? ConnectedPairedDevices { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("device_type")]
		public string? DeviceType { get; init; }

		[JsonPropertyName("dk.bilka.app.release_930771727_is_clearable")]
		public bool? Dkbilkaapprelease930771727IsClearable { get; init; }

		[JsonPropertyName("dk.bilka.app.release_930771727_is_ongoing")]
		public bool? Dkbilkaapprelease930771727IsOngoing { get; init; }

		[JsonPropertyName("dk.bilka.app.release_930771727_post_time")]
		public double? Dkbilkaapprelease930771727PostTime { get; init; }

		[JsonPropertyName("dk.coop.coopplus_0_is_clearable")]
		public bool? Dkcoopcoopplus0IsClearable { get; init; }

		[JsonPropertyName("dk.coop.coopplus_0_is_ongoing")]
		public bool? Dkcoopcoopplus0IsOngoing { get; init; }

		[JsonPropertyName("dk.coop.coopplus_0_post_time")]
		public double? Dkcoopcoopplus0PostTime { get; init; }

		[JsonPropertyName("dk.gls.consigneeapp_0_is_clearable")]
		public bool? Dkglsconsigneeapp0IsClearable { get; init; }

		[JsonPropertyName("dk.gls.consigneeapp_0_is_ongoing")]
		public bool? Dkglsconsigneeapp0IsOngoing { get; init; }

		[JsonPropertyName("dk.gls.consigneeapp_0_post_time")]
		public double? Dkglsconsigneeapp0PostTime { get; init; }

		[JsonPropertyName("dk.taenk.mitdigitaleselvforsvar_0_is_clearable")]
		public bool? Dktaenkmitdigitaleselvforsvar0IsClearable { get; init; }

		[JsonPropertyName("dk.taenk.mitdigitaleselvforsvar_0_is_ongoing")]
		public bool? Dktaenkmitdigitaleselvforsvar0IsOngoing { get; init; }

		[JsonPropertyName("dk.taenk.mitdigitaleselvforsvar_0_post_time")]
		public double? Dktaenkmitdigitaleselvforsvar0PostTime { get; init; }

		[JsonPropertyName("end")]
		public double? End { get; init; }

		[JsonPropertyName("extras_ndid_com.facebook.katana")]
		public string? ExtrasNdidComfacebookkatana { get; init; }

		[JsonPropertyName("free_external_storage")]
		public string? FreeExternalStorage { get; init; }

		[JsonPropertyName("Free internal storage")]
		public string? Freeinternalstorage { get; init; }

		[JsonPropertyName("free_memory")]
		public double? FreeMemory { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("grouping_key_com.google.android.googlequicksearchbox")]
		public string? GroupingKeyComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("io.homeassistant.companion.android_-116008064_is_clearable")]
		public bool? Iohomeassistantcompanionandroid116008064IsClearable { get; init; }

		[JsonPropertyName("io.homeassistant.companion.android_-116008064_is_ongoing")]
		public bool? Iohomeassistantcompanionandroid116008064IsOngoing { get; init; }

		[JsonPropertyName("io.homeassistant.companion.android_-116008064_post_time")]
		public double? Iohomeassistantcompanionandroid116008064PostTime { get; init; }

		[JsonPropertyName("light")]
		public double? Light { get; init; }

		[JsonPropertyName("measurement_type")]
		public string? MeasurementType { get; init; }

		[JsonPropertyName("motion")]
		public double? Motion { get; init; }

		[JsonPropertyName("opaque_token_com.google.android.googlequicksearchbox")]
		public string? OpaqueTokenComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("opa.uniqueNotificationId_com.google.android.googlequicksearchbox")]
		public double? OpauniqueNotificationIdComgoogleandroidgooglequicksearchbox { get; init; }

		[JsonPropertyName("paired_devices")]
		public string? PairedDevices { get; init; }

		[JsonPropertyName("repositories")]
		public object? Repositories { get; init; }

		[JsonPropertyName("sort_key_score_com.facebook.katana")]
		public double? SortKeyScoreComfacebookkatana { get; init; }

		[JsonPropertyName("start")]
		public double? Start { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("system_notification_extras_com.snapchat.android")]
		public string? SystemNotificationExtrasComsnapchatandroid { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }

		[JsonPropertyName("total_external_storage")]
		public string? TotalExternalStorage { get; init; }

		[JsonPropertyName("Total internal storage")]
		public string? Totalinternalstorage { get; init; }

		[JsonPropertyName("total_memory")]
		public double? TotalMemory { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public record SensorAttributes
	{
		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("album_com.podimo")]
		public string? AlbumCompodimo { get; init; }

		[JsonPropertyName("android.appInfo")]
		public string? AndroidappInfo { get; init; }

		[JsonPropertyName("android.infoText")]
		public string? AndroidinfoText { get; init; }

		[JsonPropertyName("android.largeIcon")]
		public string? AndroidlargeIcon { get; init; }

		[JsonPropertyName("android.progress")]
		public double? Androidprogress { get; init; }

		[JsonPropertyName("android.progressIndeterminate")]
		public bool? AndroidprogressIndeterminate { get; init; }

		[JsonPropertyName("android.progressMax")]
		public double? AndroidprogressMax { get; init; }

		[JsonPropertyName("android.reduced.images")]
		public bool? Androidreducedimages { get; init; }

		[JsonPropertyName("android.remoteInputHistory")]
		public string? AndroidremoteInputHistory { get; init; }

		[JsonPropertyName("android.showChronometer")]
		public bool? AndroidshowChronometer { get; init; }

		[JsonPropertyName("android.showWhen")]
		public bool? AndroidshowWhen { get; init; }

		[JsonPropertyName("android.subText")]
		public string? AndroidsubText { get; init; }

		[JsonPropertyName("android.text")]
		public string? Androidtext { get; init; }

		[JsonPropertyName("android.title")]
		public string? Androidtitle { get; init; }

		[JsonPropertyName("artist_com.podimo")]
		public string? ArtistCompodimo { get; init; }

		[JsonPropertyName("carrier id")]
		public double? Carrierid { get; init; }

		[JsonPropertyName("carrier name")]
		public string? Carriername { get; init; }

		[JsonPropertyName("Country")]
		public string? Country { get; init; }

		[JsonPropertyName("data roaming")]
		public string? Dataroaming { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("duration_com.podimo")]
		public double? DurationCompodimo { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("in_daylight_time")]
		public bool? InDaylightTime { get; init; }

		[JsonPropertyName("in_vehicle")]
		public double? InVehicle { get; init; }

		[JsonPropertyName("is_clearable")]
		public bool? IsClearable { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("iso country code")]
		public string? Isocountrycode { get; init; }

		[JsonPropertyName("is_ongoing")]
		public bool? IsOngoing { get; init; }

		[JsonPropertyName("is opportunistic")]
		public bool? Isopportunistic { get; init; }

		[JsonPropertyName("Latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("Local Time")]
		public string? LocalTime { get; init; }

		[JsonPropertyName("Longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("mcc")]
		public string? Mcc { get; init; }

		[JsonPropertyName("media_id_com.podimo")]
		public string? MediaIdCompodimo { get; init; }

		[JsonPropertyName("mnc")]
		public string? Mnc { get; init; }

		[JsonPropertyName("number_of_loaded_apps")]
		public double? NumberOfLoadedApps { get; init; }

		[JsonPropertyName("number_of_running_apps")]
		public double? NumberOfRunningApps { get; init; }

		[JsonPropertyName("on_bicycle")]
		public double? OnBicycle { get; init; }

		[JsonPropertyName("on_foot")]
		public double? OnFoot { get; init; }

		[JsonPropertyName("Package")]
		public string? Package_0 { get; init; }

		[JsonPropertyName("package")]
		public string? Package_1 { get; init; }

		[JsonPropertyName("playback_position_com.podimo")]
		public double? PlaybackPositionCompodimo { get; init; }

		[JsonPropertyName("playback_state_com.podimo")]
		public string? PlaybackStateCompodimo { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("post_time")]
		public double? PostTime { get; init; }

		[JsonPropertyName("still")]
		public double? Still { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("Time in Milliseconds")]
		public double? TimeinMilliseconds { get; init; }

		[JsonPropertyName("time_zone_id")]
		public string? TimeZoneId { get; init; }

		[JsonPropertyName("time_zone_short")]
		public string? TimeZoneShort { get; init; }

		[JsonPropertyName("title_com.podimo")]
		public string? TitleCompodimo { get; init; }

		[JsonPropertyName("total_media_session_count")]
		public double? TotalMediaSessionCount { get; init; }

		[JsonPropertyName("unknown")]
		public double? Unknown { get; init; }

		[JsonPropertyName("uses_daylight_time")]
		public bool? UsesDaylightTime { get; init; }

		[JsonPropertyName("utc_offset")]
		public double? UtcOffset { get; init; }

		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonPropertyName("walking")]
		public double? Walking { get; init; }
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("alarm_id")]
		public string? AlarmId { get; init; }

		[JsonPropertyName("duration")]
		public string? Duration { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("include_linked_zones")]
		public bool? IncludeLinkedZones { get; init; }

		[JsonPropertyName("play_mode")]
		public string? PlayMode { get; init; }

		[JsonPropertyName("recurrence")]
		public string? Recurrence { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("scheduled_today")]
		public bool? ScheduledToday { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("time")]
		public string? Time { get; init; }

		[JsonPropertyName("volume")]
		public double? Volume { get; init; }
	}

	public record VacuumAttributes
	{
		[JsonPropertyName("battery_icon")]
		public string? BatteryIcon { get; init; }

		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }

		[JsonPropertyName("fan_speed_list")]
		public object? FanSpeedList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("status")]
		public string? Status { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public object? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FfmpegServices Ffmpeg { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		InputBooleanServices InputBoolean { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		MediaPlayerServices MediaPlayer { get; }

		NetatmoServices Netatmo { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		RemoteServices Remote { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		SirenServices Siren { get; }

		SonosServices Sonos { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		VacuumServices Vacuum { get; }

		XiaomiMiioServices XiaomiMiio { get; }

		ZhaServices Zha { get; }

		ZoneServices Zone { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FfmpegServices Ffmpeg => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public NetatmoServices Netatmo => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public RemoteServices Remote => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SonosServices Sonos => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public XiaomiMiioServices XiaomiMiio => new(_haContext);
		public ZhaServices Zha => new(_haContext);
		public ZoneServices Zone => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, string? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public string? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public string? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, string @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSpeed(ServiceTarget target, FanSetSpeedParameters data)
		{
			_haContext.CallService("fan", "set_speed", target, data);
		}

		///<summary>Set fan speed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: low</param>
		public void SetSpeed(ServiceTarget target, string @speed)
		{
			_haContext.CallService("fan", "set_speed", target, new FanSetSpeedParameters{Speed = @speed});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public string? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanSetSpeedParameters
	{
		///<summary>Speed setting. eg: low</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FfmpegServices
	{
		private readonly IHaContext _haContext;
		public FfmpegServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		public void Restart(FfmpegRestartParameters data)
		{
			_haContext.CallService("ffmpeg", "restart", null, data);
		}

		///<summary>Send a restart command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will restart. Platform dependent.</param>
		public void Restart(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "restart", null, new FfmpegRestartParameters{EntityId = @entityId});
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		public void Start(FfmpegStartParameters data)
		{
			_haContext.CallService("ffmpeg", "start", null, data);
		}

		///<summary>Send a start command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will start. Platform dependent.</param>
		public void Start(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "start", null, new FfmpegStartParameters{EntityId = @entityId});
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		public void Stop(FfmpegStopParameters data)
		{
			_haContext.CallService("ffmpeg", "stop", null, data);
		}

		///<summary>Send a stop command to a ffmpeg based sensor.</summary>
		///<param name="entityId">Name of entity that will stop. Platform dependent.</param>
		public void Stop(string? @entityId = null)
		{
			_haContext.CallService("ffmpeg", "stop", null, new FfmpegStopParameters{EntityId = @entityId});
		}
	}

	public record FfmpegRestartParameters
	{
		///<summary>Name of entity that will restart. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStartParameters
	{
		///<summary>Name of entity that will start. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record FfmpegStopParameters
	{
		///<summary>Name of entity that will stop. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme, 'default' or 'none'. eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(string @name, string? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme, 'default' or 'none'. eg: default</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, string? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupFull(string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		public void BackupPartial(object? @addons = null, object? @folders = null, string? @name = null, string? @password = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Addons = @addons, Folders = @folders, Name = @name, Password = @password});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant", "share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant", "share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh", "core_samba", "core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32,87336</param>
		///<param name="longitude">Longitude of your location. eg: 117,22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32,87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117,22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, string? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public string? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public long? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public string? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, string @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public string? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class NetatmoServices
	{
		private readonly IHaContext _haContext;
		public NetatmoServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Register the webhook to the Netatmo backend.</summary>
		public void RegisterWebhook()
		{
			_haContext.CallService("netatmo", "register_webhook", null);
		}

		///<summary>Sets the light mode for a Netatmo Outdoor camera light.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCameraLight(ServiceTarget target, NetatmoSetCameraLightParameters data)
		{
			_haContext.CallService("netatmo", "set_camera_light", target, data);
		}

		///<summary>Sets the light mode for a Netatmo Outdoor camera light.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cameraLightMode">Outdoor camera light mode.</param>
		public void SetCameraLight(ServiceTarget target, string @cameraLightMode)
		{
			_haContext.CallService("netatmo", "set_camera_light", target, new NetatmoSetCameraLightParameters{CameraLightMode = @cameraLightMode});
		}

		///<summary>Set a person as away. If no person is set the home will be marked as empty. Person's name must match a name known by the Netatmo Indoor (Welcome) Camera.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPersonAway(ServiceTarget target, NetatmoSetPersonAwayParameters data)
		{
			_haContext.CallService("netatmo", "set_person_away", target, data);
		}

		///<summary>Set a person as away. If no person is set the home will be marked as empty. Person's name must match a name known by the Netatmo Indoor (Welcome) Camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="person">Person's name. eg: Bob</param>
		public void SetPersonAway(ServiceTarget target, string? @person = null)
		{
			_haContext.CallService("netatmo", "set_person_away", target, new NetatmoSetPersonAwayParameters{Person = @person});
		}

		///<summary>Set a list of persons as at home. Person's name must match a name known by the Netatmo Indoor (Welcome) Camera.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPersonsHome(ServiceTarget target, NetatmoSetPersonsHomeParameters data)
		{
			_haContext.CallService("netatmo", "set_persons_home", target, data);
		}

		///<summary>Set a list of persons as at home. Person's name must match a name known by the Netatmo Indoor (Welcome) Camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="persons">List of names eg: [Alice, Bob]</param>
		public void SetPersonsHome(ServiceTarget target, object @persons)
		{
			_haContext.CallService("netatmo", "set_persons_home", target, new NetatmoSetPersonsHomeParameters{Persons = @persons});
		}

		///<summary>Set the heating schedule for Netatmo climate device. The schedule name must match a schedule configured at Netatmo.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSchedule(ServiceTarget target, NetatmoSetScheduleParameters data)
		{
			_haContext.CallService("netatmo", "set_schedule", target, data);
		}

		///<summary>Set the heating schedule for Netatmo climate device. The schedule name must match a schedule configured at Netatmo.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="scheduleName">Schedule name eg: Standard</param>
		public void SetSchedule(ServiceTarget target, string @scheduleName)
		{
			_haContext.CallService("netatmo", "set_schedule", target, new NetatmoSetScheduleParameters{ScheduleName = @scheduleName});
		}

		///<summary>Unregister the webhook from the Netatmo backend.</summary>
		public void UnregisterWebhook()
		{
			_haContext.CallService("netatmo", "unregister_webhook", null);
		}
	}

	public record NetatmoSetCameraLightParameters
	{
		///<summary>Outdoor camera light mode.</summary>
		[JsonPropertyName("camera_light_mode")]
		public string? CameraLightMode { get; init; }
	}

	public record NetatmoSetPersonAwayParameters
	{
		///<summary>Person's name. eg: Bob</summary>
		[JsonPropertyName("person")]
		public string? Person { get; init; }
	}

	public record NetatmoSetPersonsHomeParameters
	{
		///<summary>List of names eg: [Alice, Bob]</summary>
		[JsonPropertyName("persons")]
		public object? Persons { get; init; }
	}

	public record NetatmoSetScheduleParameters
	{
		///<summary>Schedule name eg: Standard</summary>
		[JsonPropertyName("schedule_name")]
		public string? ScheduleName { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the mobile_app_jonnaphone integration.</summary>
		public void MobileAppJonnaphone(NotifyMobileAppJonnaphoneParameters data)
		{
			_haContext.CallService("notify", "mobile_app_jonnaphone", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_jonnaphone integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppJonnaphone(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_jonnaphone", null, new NotifyMobileAppJonnaphoneParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_pixel_5 integration.</summary>
		public void MobileAppPixel5(NotifyMobileAppPixel5Parameters data)
		{
			_haContext.CallService("notify", "mobile_app_pixel_5", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_pixel_5 integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppPixel5(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_pixel_5", null, new NotifyMobileAppPixel5Parameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification to the visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyMobileAppJonnaphoneParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppPixel5Parameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the regular expressions to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class RemoteServices
	{
		private readonly IHaContext _haContext;
		public RemoteServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		public void DeleteCommand(ServiceTarget target, RemoteDeleteCommandParameters data)
		{
			_haContext.CallService("remote", "delete_command", target, data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public void DeleteCommand(ServiceTarget target, object @command, string? @device = null)
		{
			_haContext.CallService("remote", "delete_command", target, new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		public void LearnCommand(ServiceTarget target, RemoteLearnCommandParameters data)
		{
			_haContext.CallService("remote", "learn_command", target, data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public void LearnCommand(ServiceTarget target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			_haContext.CallService("remote", "learn_command", target, new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, RemoteSendCommandParameters data)
		{
			_haContext.CallService("remote", "send_command", target, data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public void SendCommand(ServiceTarget target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			_haContext.CallService("remote", "send_command", target, new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("remote", "toggle", target);
		}

		///<summary>Sends the Power Off Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("remote", "turn_off", target);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, RemoteTurnOnParameters data)
		{
			_haContext.CallService("remote", "turn_on", target, data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public void TurnOn(ServiceTarget target, string? @activity = null)
		{
			_haContext.CallService("remote", "turn_on", target, new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public record RemoteDeleteCommandParameters
	{
		///<summary>Name of the device from which commands will be deleted. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to delete. eg: Mute</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }
	}

	public record RemoteLearnCommandParameters
	{
		///<summary>Device ID to learn command from. eg: television</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to learn. eg: Turn on</summary>
		[JsonPropertyName("command")]
		public object? Command { get; init; }

		///<summary>The type of command to be learned.</summary>
		[JsonPropertyName("command_type")]
		public string? CommandType { get; init; }

		///<summary>If code must be stored as alternative (useful for discrete remotes).</summary>
		[JsonPropertyName("alternative")]
		public bool? Alternative { get; init; }

		///<summary>Timeout for the command to be learned.</summary>
		[JsonPropertyName("timeout")]
		public long? Timeout { get; init; }
	}

	public record RemoteSendCommandParameters
	{
		///<summary>Device ID to send command to. eg: 32756745</summary>
		[JsonPropertyName("device")]
		public string? Device { get; init; }

		///<summary>A single command or a list of commands to send. eg: Play</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>The number of times you want to repeat the command(s).</summary>
		[JsonPropertyName("num_repeats")]
		public long? NumRepeats { get; init; }

		///<summary>The time you want to wait in between repeated commands.</summary>
		[JsonPropertyName("delay_secs")]
		public double? DelaySecs { get; init; }

		///<summary>The time you want to have it held before the release is send.</summary>
		[JsonPropertyName("hold_secs")]
		public double? HoldSecs { get; init; }
	}

	public record RemoteTurnOnParameters
	{
		///<summary>Activity ID or Activity Name to start. eg: BedroomTV</summary>
		[JsonPropertyName("activity")]
		public string? Activity { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen": "on", "light.ceiling": {"state": "on", "brightness": 80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light": "on", "light.ceiling": {"state": "on", "brightness": 200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling", "light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0,5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SonosServices
	{
		private readonly IHaContext _haContext;
		public SonosServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear a Sonos timer.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSleepTimer(ServiceTarget target)
		{
			_haContext.CallService("sonos", "clear_sleep_timer", target);
		}

		///<summary>Group player together.</summary>
		public void Join(SonosJoinParameters data)
		{
			_haContext.CallService("sonos", "join", null, data);
		}

		///<summary>Group player together.</summary>
		///<param name="master">Entity ID of the player that should become the coordinator of the group.</param>
		///<param name="entityId">Name of entity that will join the master.</param>
		public void Join(string @master, string @entityId)
		{
			_haContext.CallService("sonos", "join", null, new SonosJoinParameters{Master = @master, EntityId = @entityId});
		}

		///<summary>Start playing the queue from the first item.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayQueue(ServiceTarget target, SonosPlayQueueParameters data)
		{
			_haContext.CallService("sonos", "play_queue", target, data);
		}

		///<summary>Start playing the queue from the first item.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="queuePosition">Position of the song in the queue to start playing from.</param>
		public void PlayQueue(ServiceTarget target, long? @queuePosition = null)
		{
			_haContext.CallService("sonos", "play_queue", target, new SonosPlayQueueParameters{QueuePosition = @queuePosition});
		}

		///<summary>Removes an item from the queue.</summary>
		///<param name="target">The target for this service call</param>
		public void RemoveFromQueue(ServiceTarget target, SonosRemoveFromQueueParameters data)
		{
			_haContext.CallService("sonos", "remove_from_queue", target, data);
		}

		///<summary>Removes an item from the queue.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="queuePosition">Position in the queue to remove.</param>
		public void RemoveFromQueue(ServiceTarget target, long? @queuePosition = null)
		{
			_haContext.CallService("sonos", "remove_from_queue", target, new SonosRemoveFromQueueParameters{QueuePosition = @queuePosition});
		}

		///<summary>Restore a snapshot of the media player.</summary>
		public void Restore(SonosRestoreParameters data)
		{
			_haContext.CallService("sonos", "restore", null, data);
		}

		///<summary>Restore a snapshot of the media player.</summary>
		///<param name="entityId">Name of entity that will be restored.</param>
		///<param name="withGroup">True or False. Also restore the group layout.</param>
		public void Restore(string? @entityId = null, bool? @withGroup = null)
		{
			_haContext.CallService("sonos", "restore", null, new SonosRestoreParameters{EntityId = @entityId, WithGroup = @withGroup});
		}

		///<summary>Set a Sonos timer.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSleepTimer(ServiceTarget target, SonosSetSleepTimerParameters data)
		{
			_haContext.CallService("sonos", "set_sleep_timer", target, data);
		}

		///<summary>Set a Sonos timer.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="sleepTime">Number of seconds to set the timer.</param>
		public void SetSleepTimer(ServiceTarget target, long? @sleepTime = null)
		{
			_haContext.CallService("sonos", "set_sleep_timer", target, new SonosSetSleepTimerParameters{SleepTime = @sleepTime});
		}

		///<summary>Take a snapshot of the media player.</summary>
		public void Snapshot(SonosSnapshotParameters data)
		{
			_haContext.CallService("sonos", "snapshot", null, data);
		}

		///<summary>Take a snapshot of the media player.</summary>
		///<param name="entityId">Name of entity that will be snapshot.</param>
		///<param name="withGroup">True or False. Also snapshot the group layout.</param>
		public void Snapshot(string? @entityId = null, bool? @withGroup = null)
		{
			_haContext.CallService("sonos", "snapshot", null, new SonosSnapshotParameters{EntityId = @entityId, WithGroup = @withGroup});
		}

		///<summary>Unjoin the player from a group.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("sonos", "unjoin", target);
		}

		///<summary>Updates an alarm with new time and volume settings.</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateAlarm(ServiceTarget target, SonosUpdateAlarmParameters data)
		{
			_haContext.CallService("sonos", "update_alarm", target, data);
		}

		///<summary>Updates an alarm with new time and volume settings.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="alarmId">ID for the alarm to be updated.</param>
		///<param name="time">Set time for the alarm. eg: 07:00</param>
		///<param name="volume">Set alarm volume level.</param>
		///<param name="enabled">Enable or disable the alarm.</param>
		///<param name="includeLinkedZones">Enable or disable including grouped rooms.</param>
		public void UpdateAlarm(ServiceTarget target, long @alarmId, DateTime? @time = null, double? @volume = null, bool? @enabled = null, bool? @includeLinkedZones = null)
		{
			_haContext.CallService("sonos", "update_alarm", target, new SonosUpdateAlarmParameters{AlarmId = @alarmId, Time = @time, Volume = @volume, Enabled = @enabled, IncludeLinkedZones = @includeLinkedZones});
		}
	}

	public record SonosJoinParameters
	{
		///<summary>Entity ID of the player that should become the coordinator of the group.</summary>
		[JsonPropertyName("master")]
		public string? Master { get; init; }

		///<summary>Name of entity that will join the master.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }
	}

	public record SonosPlayQueueParameters
	{
		///<summary>Position of the song in the queue to start playing from.</summary>
		[JsonPropertyName("queue_position")]
		public long? QueuePosition { get; init; }
	}

	public record SonosRemoveFromQueueParameters
	{
		///<summary>Position in the queue to remove.</summary>
		[JsonPropertyName("queue_position")]
		public long? QueuePosition { get; init; }
	}

	public record SonosRestoreParameters
	{
		///<summary>Name of entity that will be restored.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>True or False. Also restore the group layout.</summary>
		[JsonPropertyName("with_group")]
		public bool? WithGroup { get; init; }
	}

	public record SonosSetSleepTimerParameters
	{
		///<summary>Number of seconds to set the timer.</summary>
		[JsonPropertyName("sleep_time")]
		public long? SleepTime { get; init; }
	}

	public record SonosSnapshotParameters
	{
		///<summary>Name of entity that will be snapshot.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>True or False. Also snapshot the group layout.</summary>
		[JsonPropertyName("with_group")]
		public bool? WithGroup { get; init; }
	}

	public record SonosUpdateAlarmParameters
	{
		///<summary>ID for the alarm to be updated.</summary>
		[JsonPropertyName("alarm_id")]
		public long? AlarmId { get; init; }

		///<summary>Set time for the alarm. eg: 07:00</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>Set alarm volume level.</summary>
		[JsonPropertyName("volume")]
		public double? Volume { get; init; }

		///<summary>Enable or disable the alarm.</summary>
		[JsonPropertyName("enabled")]
		public bool? Enabled { get; init; }

		///<summary>Enable or disable including grouped rooms.</summary>
		[JsonPropertyName("include_linked_zones")]
		public bool? IncludeLinkedZones { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, string? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public string? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		public void CloudSay(TtsCloudSayParameters data)
		{
			_haContext.CallService("tts", "cloud_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "cloud_say", null, new TtsCloudSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
		{
			_haContext.CallService("tts", "google_translate_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_translate_say", null, new TtsGoogleTranslateSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsCloudSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleTranslateSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class XiaomiMiioServices
	{
		private readonly IHaContext _haContext;
		public XiaomiMiioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanSegment(ServiceTarget target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The target for this service call</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public void VacuumCleanSegment(ServiceTarget target, object? @segments = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_segment", target, new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumCleanZone(ServiceTarget target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public void VacuumCleanZone(ServiceTarget target, object? @zone = null, long? @repeats = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_clean_zone", target, new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumGoto(ServiceTarget target, XiaomiMiioVacuumGotoParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public void VacuumGoto(ServiceTarget target, string? @xCoord = null, string? @yCoord = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_goto", target, new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMove(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMove(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move", target, new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public void VacuumRemoteControlMoveStep(ServiceTarget target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_move_step", target, new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStart(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_start", target);
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void VacuumRemoteControlStop(ServiceTarget target)
		{
			_haContext.CallService("xiaomi_miio", "vacuum_remote_control_stop", target);
		}
	}

	public record XiaomiMiioVacuumCleanSegmentParameters
	{
		///<summary>Segments. eg: [1,2]</summary>
		[JsonPropertyName("segments")]
		public object? Segments { get; init; }
	}

	public record XiaomiMiioVacuumCleanZoneParameters
	{
		///<summary>Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</summary>
		[JsonPropertyName("zone")]
		public object? Zone { get; init; }

		///<summary>Number of cleaning repeats for each zone.</summary>
		[JsonPropertyName("repeats")]
		public long? Repeats { get; init; }
	}

	public record XiaomiMiioVacuumGotoParameters
	{
		///<summary>x-coordinate. eg: 27500</summary>
		[JsonPropertyName("x_coord")]
		public string? XCoord { get; init; }

		///<summary>y-coordinate. eg: 32000</summary>
		[JsonPropertyName("y_coord")]
		public string? YCoord { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation, between -179 degrees and 179 degrees.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record XiaomiMiioVacuumRemoteControlMoveStepParameters
	{
		///<summary>Speed.</summary>
		[JsonPropertyName("velocity")]
		public double? Velocity { get; init; }

		///<summary>Rotation.</summary>
		[JsonPropertyName("rotation")]
		public long? Rotation { get; init; }

		///<summary>Duration of the movement.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public class ZhaServices
	{
		private readonly IHaContext _haContext;
		public ZhaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		public void ClearLockUserCode(ServiceTarget target, ZhaClearLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public void ClearLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void DisableLockUserCode(ServiceTarget target, ZhaDisableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public void DisableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void EnableLockUserCode(ServiceTarget target, ZhaEnableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public void EnableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		public void IssueZigbeeClusterCommand(ZhaIssueZigbeeClusterCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="commandType">type of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeClusterCommand(string @ieee, long @endpointId, long @clusterId, long @command, string @commandType, string? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, new ZhaIssueZigbeeClusterCommandParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, CommandType = @commandType, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		public void IssueZigbeeGroupCommand(ZhaIssueZigbeeGroupCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		///<param name="group">Hexadecimal address of the group eg: 546</param>
		///<param name="clusterId">ZCL cluster to send command to</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeGroupCommand(string @group, long @clusterId, long @command, string? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, new ZhaIssueZigbeeGroupCommandParameters{Group = @group, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		public void Permit(ZhaPermitParameters data)
		{
			_haContext.CallService("zha", "permit", null, data);
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		///<param name="duration">Time to permit joins, in seconds</param>
		///<param name="ieee">IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="sourceIeee">IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</param>
		///<param name="installCode">Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</param>
		///<param name="qrCode">value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</param>
		public void Permit(long? @duration = null, string? @ieee = null, string? @sourceIeee = null, string? @installCode = null, string? @qrCode = null)
		{
			_haContext.CallService("zha", "permit", null, new ZhaPermitParameters{Duration = @duration, Ieee = @ieee, SourceIeee = @sourceIeee, InstallCode = @installCode, QrCode = @qrCode});
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		public void Remove(ZhaRemoveParameters data)
		{
			_haContext.CallService("zha", "remove", null, data);
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		///<param name="ieee">IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</param>
		public void Remove(string @ieee)
		{
			_haContext.CallService("zha", "remove", null, new ZhaRemoveParameters{Ieee = @ieee});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void SetLockUserCode(ServiceTarget target, ZhaSetLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public void SetLockUserCode(ServiceTarget target, string @codeSlot, string @userCode)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		public void SetZigbeeClusterAttribute(ZhaSetZigbeeClusterAttributeParameters data)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, data);
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="attribute">id of the attribute to set eg: 0</param>
		///<param name="value">value to write to the attribute eg: 1</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void SetZigbeeClusterAttribute(string @ieee, long @endpointId, long @clusterId, long @attribute, string @value, string? @clusterType = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, new ZhaSetZigbeeClusterAttributeParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Attribute = @attribute, Value = @value, Manufacturer = @manufacturer});
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		public void WarningDeviceSquawk(ZhaWarningDeviceSquawkParameters data)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, data);
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</param>
		///<param name="strobe">The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</param>
		///<param name="level">The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</param>
		public void WarningDeviceSquawk(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, new ZhaWarningDeviceSquawkParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level});
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		public void WarningDeviceWarn(ZhaWarningDeviceWarnParameters data)
		{
			_haContext.CallService("zha", "warning_device_warn", null, data);
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</param>
		///<param name="strobe">The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</param>
		///<param name="level">The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</param>
		///<param name="duration">Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</param>
		///<param name="dutyCycle">Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</param>
		///<param name="intensity">Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</param>
		public void WarningDeviceWarn(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null, long? @duration = null, long? @dutyCycle = null, long? @intensity = null)
		{
			_haContext.CallService("zha", "warning_device_warn", null, new ZhaWarningDeviceWarnParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level, Duration = @duration, DutyCycle = @dutyCycle, Intensity = @intensity});
		}
	}

	public record ZhaClearLockUserCodeParameters
	{
		///<summary>Code slot to clear code from eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaDisableLockUserCodeParameters
	{
		///<summary>Code slot to disable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaEnableLockUserCodeParameters
	{
		///<summary>Code slot to enable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaIssueZigbeeClusterCommandParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public string? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>type of the command to execute</summary>
		[JsonPropertyName("command_type")]
		public string? CommandType { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaIssueZigbeeGroupCommandParameters
	{
		///<summary>Hexadecimal address of the group eg: 546</summary>
		[JsonPropertyName("group")]
		public string? Group { get; init; }

		///<summary>ZCL cluster to send command to</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public string? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaPermitParameters
	{
		///<summary>Time to permit joins, in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</summary>
		[JsonPropertyName("source_ieee")]
		public string? SourceIeee { get; init; }

		///<summary>Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</summary>
		[JsonPropertyName("install_code")]
		public string? InstallCode { get; init; }

		///<summary>value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</summary>
		[JsonPropertyName("qr_code")]
		public string? QrCode { get; init; }
	}

	public record ZhaRemoveParameters
	{
		///<summary>IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }
	}

	public record ZhaSetLockUserCodeParameters
	{
		///<summary>Code slot to set the code in eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }

		///<summary>Code to set eg: 1234</summary>
		[JsonPropertyName("user_code")]
		public string? UserCode { get; init; }
	}

	public record ZhaSetZigbeeClusterAttributeParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public string? ClusterType { get; init; }

		///<summary>id of the attribute to set eg: 0</summary>
		[JsonPropertyName("attribute")]
		public long? Attribute { get; init; }

		///<summary>value to write to the attribute eg: 1</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaWarningDeviceSquawkParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }
	}

	public record ZhaWarningDeviceWarnParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }

		///<summary>Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</summary>
		[JsonPropertyName("duty_cycle")]
		public long? DutyCycle { get; init; }

		///<summary>Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</summary>
		[JsonPropertyName("intensity")]
		public long? Intensity { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
            target.CallService("toggle");
        }

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ClimateEntityExtensionMethods
	{
		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this ClimateEntity target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, ClimateSetAuxHeatParameters data)
		{
			target.CallService("set_aux_heat", data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this ClimateEntity target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public static void SetAuxHeat(this IEnumerable<ClimateEntity> target, bool @auxHeat)
		{
			target.CallService("set_aux_heat", new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this ClimateEntity target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, ClimateSetFanModeParameters data)
		{
			target.CallService("set_fan_mode", data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this ClimateEntity target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public static void SetFanMode(this IEnumerable<ClimateEntity> target, string @fanMode)
		{
			target.CallService("set_fan_mode", new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this ClimateEntity target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, ClimateSetHumidityParameters data)
		{
			target.CallService("set_humidity", data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this ClimateEntity target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public static void SetHumidity(this IEnumerable<ClimateEntity> target, long @humidity)
		{
			target.CallService("set_humidity", new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this ClimateEntity target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, ClimateSetHvacModeParameters data)
		{
			target.CallService("set_hvac_mode", data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this ClimateEntity target, string? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public static void SetHvacMode(this IEnumerable<ClimateEntity> target, string? @hvacMode = null)
		{
			target.CallService("set_hvac_mode", new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this ClimateEntity target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, ClimateSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this ClimateEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public static void SetPresetMode(this IEnumerable<ClimateEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this ClimateEntity target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, ClimateSetSwingModeParameters data)
		{
			target.CallService("set_swing_mode", data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this ClimateEntity target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public static void SetSwingMode(this IEnumerable<ClimateEntity> target, string @swingMode)
		{
			target.CallService("set_swing_mode", new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this ClimateEntity target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, ClimateSetTemperatureParameters data)
		{
			target.CallService("set_temperature", data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this ClimateEntity target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public static void SetTemperature(this IEnumerable<ClimateEntity> target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, string? @hvacMode = null)
		{
			target.CallService("set_temperature", new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this ClimateEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device off.</summary>
		public static void TurnOff(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this ClimateEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn climate device on.</summary>
		public static void TurnOn(this IEnumerable<ClimateEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CounterEntityExtensionMethods
	{
		///<summary>Change counter parameters.</summary>
		public static void Configure(this CounterEntity target, CounterConfigureParameters data)
		{
			target.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		public static void Configure(this IEnumerable<CounterEntity> target, CounterConfigureParameters data)
		{
			target.CallService("configure", data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The CounterEntity to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this CounterEntity target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			target.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The IEnumerable<CounterEntity> to call this service for</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public static void Configure(this IEnumerable<CounterEntity> target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			target.CallService("configure", new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this CounterEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement a counter.</summary>
		public static void Decrement(this IEnumerable<CounterEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this CounterEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment a counter.</summary>
		public static void Increment(this IEnumerable<CounterEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this CounterEntity target)
		{
			target.CallService("reset");
		}

		///<summary>Reset a counter.</summary>
		public static void Reset(this IEnumerable<CounterEntity> target)
		{
			target.CallService("reset");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, string? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, string? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">A list containing three integers between 0 and 255 representing the RGB (red, green, blue) color for the light. eg: [255, 100, 100]</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, string? @colorName = null, object? @hsColor = null, object? @xyColor = null, long? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, string? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class LockEntityExtensionMethods
	{
		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this LockEntity target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		public static void Lock(this IEnumerable<LockEntity> target, LockLockParameters data)
		{
			target.CallService("lock", data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this LockEntity target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public static void Lock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("lock", new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this LockEntity target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		public static void Open(this IEnumerable<LockEntity> target, LockOpenParameters data)
		{
			target.CallService("open", data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this LockEntity target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public static void Open(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("open", new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this LockEntity target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		public static void Unlock(this IEnumerable<LockEntity> target, LockUnlockParameters data)
		{
			target.CallService("unlock", data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this LockEntity target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public static void Unlock(this IEnumerable<LockEntity> target, string? @code = null)
		{
			target.CallService("unlock", new LockUnlockParameters{Code = @code});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2", "media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, string @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, string @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NetatmoEntityExtensionMethods
	{
		///<summary>Sets the light mode for a Netatmo Outdoor camera light.</summary>
		public static void SetCameraLight(this LightEntity target, NetatmoSetCameraLightParameters data)
		{
			target.CallService("set_camera_light", data);
		}

		///<summary>Sets the light mode for a Netatmo Outdoor camera light.</summary>
		public static void SetCameraLight(this IEnumerable<LightEntity> target, NetatmoSetCameraLightParameters data)
		{
			target.CallService("set_camera_light", data);
		}

		///<summary>Sets the light mode for a Netatmo Outdoor camera light.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="cameraLightMode">Outdoor camera light mode.</param>
		public static void SetCameraLight(this LightEntity target, string @cameraLightMode)
		{
			target.CallService("set_camera_light", new NetatmoSetCameraLightParameters{CameraLightMode = @cameraLightMode});
		}

		///<summary>Sets the light mode for a Netatmo Outdoor camera light.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="cameraLightMode">Outdoor camera light mode.</param>
		public static void SetCameraLight(this IEnumerable<LightEntity> target, string @cameraLightMode)
		{
			target.CallService("set_camera_light", new NetatmoSetCameraLightParameters{CameraLightMode = @cameraLightMode});
		}

		///<summary>Set the heating schedule for Netatmo climate device. The schedule name must match a schedule configured at Netatmo.</summary>
		public static void SetSchedule(this ClimateEntity target, NetatmoSetScheduleParameters data)
		{
			target.CallService("set_schedule", data);
		}

		///<summary>Set the heating schedule for Netatmo climate device. The schedule name must match a schedule configured at Netatmo.</summary>
		public static void SetSchedule(this IEnumerable<ClimateEntity> target, NetatmoSetScheduleParameters data)
		{
			target.CallService("set_schedule", data);
		}

		///<summary>Set the heating schedule for Netatmo climate device. The schedule name must match a schedule configured at Netatmo.</summary>
		///<param name="target">The ClimateEntity to call this service for</param>
		///<param name="scheduleName">Schedule name eg: Standard</param>
		public static void SetSchedule(this ClimateEntity target, string @scheduleName)
		{
			target.CallService("set_schedule", new NetatmoSetScheduleParameters{ScheduleName = @scheduleName});
		}

		///<summary>Set the heating schedule for Netatmo climate device. The schedule name must match a schedule configured at Netatmo.</summary>
		///<param name="target">The IEnumerable<ClimateEntity> to call this service for</param>
		///<param name="scheduleName">Schedule name eg: Standard</param>
		public static void SetSchedule(this IEnumerable<ClimateEntity> target, string @scheduleName)
		{
			target.CallService("set_schedule", new NetatmoSetScheduleParameters{ScheduleName = @scheduleName});
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class RemoteEntityExtensionMethods
	{
		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this RemoteEntity target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, RemoteDeleteCommandParameters data)
		{
			target.CallService("delete_command", data);
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this RemoteEntity target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Deletes a command or a list of commands from the database.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Name of the device from which commands will be deleted. eg: television</param>
		///<param name="command">A single command or a list of commands to delete. eg: Mute</param>
		public static void DeleteCommand(this IEnumerable<RemoteEntity> target, object @command, string? @device = null)
		{
			target.CallService("delete_command", new RemoteDeleteCommandParameters{Device = @device, Command = @command});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this RemoteEntity target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, RemoteLearnCommandParameters data)
		{
			target.CallService("learn_command", data);
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this RemoteEntity target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Learns a command or a list of commands from a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to learn command from. eg: television</param>
		///<param name="command">A single command or a list of commands to learn. eg: Turn on</param>
		///<param name="commandType">The type of command to be learned.</param>
		///<param name="alternative">If code must be stored as alternative (useful for discrete remotes).</param>
		///<param name="timeout">Timeout for the command to be learned.</param>
		public static void LearnCommand(this IEnumerable<RemoteEntity> target, string? @device = null, object? @command = null, string? @commandType = null, bool? @alternative = null, long? @timeout = null)
		{
			target.CallService("learn_command", new RemoteLearnCommandParameters{Device = @device, Command = @command, CommandType = @commandType, Alternative = @alternative, Timeout = @timeout});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this RemoteEntity target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, RemoteSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this RemoteEntity target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Sends a command or a list of commands to a device.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="device">Device ID to send command to. eg: 32756745</param>
		///<param name="command">A single command or a list of commands to send. eg: Play</param>
		///<param name="numRepeats">The number of times you want to repeat the command(s).</param>
		///<param name="delaySecs">The time you want to wait in between repeated commands.</param>
		///<param name="holdSecs">The time you want to have it held before the release is send.</param>
		public static void SendCommand(this IEnumerable<RemoteEntity> target, string @command, string? @device = null, long? @numRepeats = null, double? @delaySecs = null, double? @holdSecs = null)
		{
			target.CallService("send_command", new RemoteSendCommandParameters{Device = @device, Command = @command, NumRepeats = @numRepeats, DelaySecs = @delaySecs, HoldSecs = @holdSecs});
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this RemoteEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a device.</summary>
		public static void Toggle(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this RemoteEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power Off Command.</summary>
		public static void TurnOff(this IEnumerable<RemoteEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this RemoteEntity target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, RemoteTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The RemoteEntity to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this RemoteEntity target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}

		///<summary>Sends the Power On Command.</summary>
		///<param name="target">The IEnumerable<RemoteEntity> to call this service for</param>
		///<param name="activity">Activity ID or Activity Name to start. eg: BedroomTV</param>
		public static void TurnOn(this IEnumerable<RemoteEntity> target, string? @activity = null)
		{
			target.CallService("turn_on", new RemoteTurnOnParameters{Activity = @activity});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this IEnumerable<SceneEntity> target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SonosEntityExtensionMethods
	{
		///<summary>Unjoin the player from a group.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class VacuumEntityExtensionMethods
	{
		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this VacuumEntity target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		public static void CleanSpot(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("clean_spot");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this VacuumEntity target)
		{
			target.CallService("locate");
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		public static void Locate(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("locate");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this VacuumEntity target)
		{
			target.CallService("pause");
		}

		///<summary>Pause the cleaning task.</summary>
		public static void Pause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("pause");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this VacuumEntity target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		public static void ReturnToBase(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("return_to_base");
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this VacuumEntity target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, VacuumSendCommandParameters data)
		{
			target.CallService("send_command", data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this VacuumEntity target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public static void SendCommand(this IEnumerable<VacuumEntity> target, string @command, object? @params = null)
		{
			target.CallService("send_command", new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this VacuumEntity target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, VacuumSetFanSpeedParameters data)
		{
			target.CallService("set_fan_speed", data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this VacuumEntity target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public static void SetFanSpeed(this IEnumerable<VacuumEntity> target, string @fanSpeed)
		{
			target.CallService("set_fan_speed", new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this VacuumEntity target)
		{
			target.CallService("start");
		}

		///<summary>Start or resume the cleaning task.</summary>
		public static void Start(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this VacuumEntity target)
		{
			target.CallService("start_pause");
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		public static void StartPause(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("start_pause");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this VacuumEntity target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task.</summary>
		public static void Stop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("stop");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this VacuumEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		public static void TurnOff(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this VacuumEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Start a new cleaning task.</summary>
		public static void TurnOn(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class XiaomiMiioEntityExtensionMethods
	{
		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this VacuumEntity target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanSegmentParameters data)
		{
			target.CallService("vacuum_clean_segment", data);
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this VacuumEntity target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start cleaning of the specified segment(s).</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="segments">Segments. eg: [1,2]</param>
		public static void VacuumCleanSegment(this IEnumerable<VacuumEntity> target, object? @segments = null)
		{
			target.CallService("vacuum_clean_segment", new XiaomiMiioVacuumCleanSegmentParameters{Segments = @segments});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this VacuumEntity target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumCleanZoneParameters data)
		{
			target.CallService("vacuum_clean_zone", data);
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this VacuumEntity target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Start the cleaning operation in the selected areas for the number of repeats indicated.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="zone">Array of zones. Each zone is an array of 4 integer values. eg: [[23510,25311,25110,26362]]</param>
		///<param name="repeats">Number of cleaning repeats for each zone.</param>
		public static void VacuumCleanZone(this IEnumerable<VacuumEntity> target, object? @zone = null, long? @repeats = null)
		{
			target.CallService("vacuum_clean_zone", new XiaomiMiioVacuumCleanZoneParameters{Zone = @zone, Repeats = @repeats});
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this VacuumEntity target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumGotoParameters data)
		{
			target.CallService("vacuum_goto", data);
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this VacuumEntity target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Go to the specified coordinates.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="xCoord">x-coordinate. eg: 27500</param>
		///<param name="yCoord">y-coordinate. eg: 32000</param>
		public static void VacuumGoto(this IEnumerable<VacuumEntity> target, string? @xCoord = null, string? @yCoord = null)
		{
			target.CallService("vacuum_goto", new XiaomiMiioVacuumGotoParameters{XCoord = @xCoord, YCoord = @yCoord});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveParameters data)
		{
			target.CallService("vacuum_remote_control_move", data);
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, make sure you first set it in remote control mode with `remote_control_start`.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation, between -179 degrees and 179 degrees.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMove(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move", new XiaomiMiioVacuumRemoteControlMoveParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, XiaomiMiioVacuumRemoteControlMoveStepParameters data)
		{
			target.CallService("vacuum_remote_control_move_step", data);
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The VacuumEntity to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this VacuumEntity target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Remote control the vacuum cleaner, only makes one move and then stops.</summary>
		///<param name="target">The IEnumerable<VacuumEntity> to call this service for</param>
		///<param name="velocity">Speed.</param>
		///<param name="rotation">Rotation.</param>
		///<param name="duration">Duration of the movement.</param>
		public static void VacuumRemoteControlMoveStep(this IEnumerable<VacuumEntity> target, double? @velocity = null, long? @rotation = null, long? @duration = null)
		{
			target.CallService("vacuum_remote_control_move_step", new XiaomiMiioVacuumRemoteControlMoveStepParameters{Velocity = @velocity, Rotation = @rotation, Duration = @duration});
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Start remote control of the vacuum cleaner. You can then move it with `remote_control_move`, when done call `remote_control_stop`.</summary>
		public static void VacuumRemoteControlStart(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_start");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this VacuumEntity target)
		{
			target.CallService("vacuum_remote_control_stop");
		}

		///<summary>Stop remote control mode of the vacuum cleaner.</summary>
		public static void VacuumRemoteControlStop(this IEnumerable<VacuumEntity> target)
		{
			target.CallService("vacuum_remote_control_stop");
		}
	}

	public static class ZhaEntityExtensionMethods
	{
		///<summary>Clear a user code from a lock</summary>
		public static void ClearLockUserCode(this LockEntity target, ZhaClearLockUserCodeParameters data)
		{
			target.CallService("clear_lock_user_code", data);
		}

		///<summary>Clear a user code from a lock</summary>
		public static void ClearLockUserCode(this IEnumerable<LockEntity> target, ZhaClearLockUserCodeParameters data)
		{
			target.CallService("clear_lock_user_code", data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("clear_lock_user_code", new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public static void ClearLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("clear_lock_user_code", new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		public static void DisableLockUserCode(this LockEntity target, ZhaDisableLockUserCodeParameters data)
		{
			target.CallService("disable_lock_user_code", data);
		}

		///<summary>Disable a user code on a lock</summary>
		public static void DisableLockUserCode(this IEnumerable<LockEntity> target, ZhaDisableLockUserCodeParameters data)
		{
			target.CallService("disable_lock_user_code", data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public static void DisableLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("disable_lock_user_code", new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public static void DisableLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("disable_lock_user_code", new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		public static void EnableLockUserCode(this LockEntity target, ZhaEnableLockUserCodeParameters data)
		{
			target.CallService("enable_lock_user_code", data);
		}

		///<summary>Enable a user code on a lock</summary>
		public static void EnableLockUserCode(this IEnumerable<LockEntity> target, ZhaEnableLockUserCodeParameters data)
		{
			target.CallService("enable_lock_user_code", data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public static void EnableLockUserCode(this LockEntity target, string @codeSlot)
		{
			target.CallService("enable_lock_user_code", new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public static void EnableLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot)
		{
			target.CallService("enable_lock_user_code", new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Set a user code on a lock</summary>
		public static void SetLockUserCode(this LockEntity target, ZhaSetLockUserCodeParameters data)
		{
			target.CallService("set_lock_user_code", data);
		}

		///<summary>Set a user code on a lock</summary>
		public static void SetLockUserCode(this IEnumerable<LockEntity> target, ZhaSetLockUserCodeParameters data)
		{
			target.CallService("set_lock_user_code", data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The LockEntity to call this service for</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public static void SetLockUserCode(this LockEntity target, string @codeSlot, string @userCode)
		{
			target.CallService("set_lock_user_code", new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The IEnumerable<LockEntity> to call this service for</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public static void SetLockUserCode(this IEnumerable<LockEntity> target, string @codeSlot, string @userCode)
		{
			target.CallService("set_lock_user_code", new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}
	}
}