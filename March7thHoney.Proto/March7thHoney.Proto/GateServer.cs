using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GateServer : IMessage<GateServer>, IMessage, IEquatable<GateServer>, IDeepCloneable<GateServer>, IBufferMessage
{
	private static readonly MessageParser<GateServer> _parser = new MessageParser<GateServer>(() => new GateServer());

	private UnknownFieldSet _unknownFields;

	public const int IpFieldNumber = 3;

	private string ip_ = "";

	public const int LuaUrlFieldNumber = 6;

	private string luaUrl_ = "";

	public const int PortFieldNumber = 7;

	private uint port_;

	public const int RegionNameFieldNumber = 9;

	private string regionName_ = "";

	public const int Unk1FieldNumber = 10;

	private bool unk1_;

	public const int ExResourceUrlFieldNumber = 11;

	private string exResourceUrl_ = "";

	public const int AssetBundleUrlFieldNumber = 12;

	private string assetBundleUrl_ = "";

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int Unk2FieldNumber = 15;

	private bool unk2_;

	public const int MsgFieldNumber = 43;

	private string msg_ = "";

	public const int Unk3FieldNumber = 67;

	private bool unk3_;

	public const int Unk4FieldNumber = 79;

	private bool unk4_;

	public const int Unk10FieldNumber = 112;

	private bool unk10_;

	public const int Unk5FieldNumber = 184;

	private bool unk5_;

	public const int Unk6FieldNumber = 200;

	private bool unk6_;

	public const int Unk14FieldNumber = 208;

	private bool unk14_;

	public const int Unk13FieldNumber = 393;

	private bool unk13_;

	public const int Unk7FieldNumber = 454;

	private bool unk7_;

	public const int Unk8FieldNumber = 529;

	private bool unk8_;

	public const int Unk15FieldNumber = 929;

	private bool unk15_;

	public const int Unk16FieldNumber = 975;

	private bool unk16_;

	public const int IfixVersionFieldNumber = 1178;

	private string ifixVersion_ = "";

	public const int MdkResVersionFieldNumber = 1238;

	private string mdkResVersion_ = "";

	public const int Unk12FieldNumber = 1276;

	private bool unk12_;

	public const int AssetBundleUrlAndroidFieldNumber = 1417;

	private string assetBundleUrlAndroid_ = "";

	public const int Unk11FieldNumber = 1440;

	private bool unk11_;

	public const int IfixUrlFieldNumber = 1488;

	private string ifixUrl_ = "";

	public const int Unk9FieldNumber = 1686;

	private bool unk9_;

	public const int ClientSecretKeyFieldNumber = 721;

	private string clientSecretKey_ = "";

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GateServer> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GateServerReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Ip
	{
		get
		{
			return ip_;
		}
		set
		{
			ip_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LuaUrl
	{
		get
		{
			return luaUrl_;
		}
		set
		{
			luaUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Port
	{
		get
		{
			return port_;
		}
		set
		{
			port_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RegionName
	{
		get
		{
			return regionName_;
		}
		set
		{
			regionName_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk1
	{
		get
		{
			return unk1_;
		}
		set
		{
			unk1_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ExResourceUrl
	{
		get
		{
			return exResourceUrl_;
		}
		set
		{
			exResourceUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AssetBundleUrl
	{
		get
		{
			return assetBundleUrl_;
		}
		set
		{
			assetBundleUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk2
	{
		get
		{
			return unk2_;
		}
		set
		{
			unk2_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Msg
	{
		get
		{
			return msg_;
		}
		set
		{
			msg_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk3
	{
		get
		{
			return unk3_;
		}
		set
		{
			unk3_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk4
	{
		get
		{
			return unk4_;
		}
		set
		{
			unk4_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk10
	{
		get
		{
			return unk10_;
		}
		set
		{
			unk10_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk5
	{
		get
		{
			return unk5_;
		}
		set
		{
			unk5_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk6
	{
		get
		{
			return unk6_;
		}
		set
		{
			unk6_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk14
	{
		get
		{
			return unk14_;
		}
		set
		{
			unk14_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk13
	{
		get
		{
			return unk13_;
		}
		set
		{
			unk13_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk7
	{
		get
		{
			return unk7_;
		}
		set
		{
			unk7_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk8
	{
		get
		{
			return unk8_;
		}
		set
		{
			unk8_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk15
	{
		get
		{
			return unk15_;
		}
		set
		{
			unk15_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk16
	{
		get
		{
			return unk16_;
		}
		set
		{
			unk16_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IfixVersion
	{
		get
		{
			return ifixVersion_;
		}
		set
		{
			ifixVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string MdkResVersion
	{
		get
		{
			return mdkResVersion_;
		}
		set
		{
			mdkResVersion_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk12
	{
		get
		{
			return unk12_;
		}
		set
		{
			unk12_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AssetBundleUrlAndroid
	{
		get
		{
			return assetBundleUrlAndroid_;
		}
		set
		{
			assetBundleUrlAndroid_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk11
	{
		get
		{
			return unk11_;
		}
		set
		{
			unk11_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IfixUrl
	{
		get
		{
			return ifixUrl_;
		}
		set
		{
			ifixUrl_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Unk9
	{
		get
		{
			return unk9_;
		}
		set
		{
			unk9_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ClientSecretKey
	{
		get
		{
			return clientSecretKey_;
		}
		set
		{
			clientSecretKey_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GateServer()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GateServer(GateServer other)
		: this()
	{
		ip_ = other.ip_;
		luaUrl_ = other.luaUrl_;
		port_ = other.port_;
		regionName_ = other.regionName_;
		unk1_ = other.unk1_;
		exResourceUrl_ = other.exResourceUrl_;
		assetBundleUrl_ = other.assetBundleUrl_;
		retcode_ = other.retcode_;
		unk2_ = other.unk2_;
		msg_ = other.msg_;
		unk3_ = other.unk3_;
		unk4_ = other.unk4_;
		unk10_ = other.unk10_;
		unk5_ = other.unk5_;
		unk6_ = other.unk6_;
		unk14_ = other.unk14_;
		unk13_ = other.unk13_;
		unk7_ = other.unk7_;
		unk8_ = other.unk8_;
		unk15_ = other.unk15_;
		unk16_ = other.unk16_;
		ifixVersion_ = other.ifixVersion_;
		mdkResVersion_ = other.mdkResVersion_;
		unk12_ = other.unk12_;
		assetBundleUrlAndroid_ = other.assetBundleUrlAndroid_;
		unk11_ = other.unk11_;
		ifixUrl_ = other.ifixUrl_;
		unk9_ = other.unk9_;
		clientSecretKey_ = other.clientSecretKey_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GateServer Clone()
	{
		return new GateServer(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GateServer);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GateServer other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Ip != other.Ip)
		{
			return false;
		}
		if (LuaUrl != other.LuaUrl)
		{
			return false;
		}
		if (Port != other.Port)
		{
			return false;
		}
		if (RegionName != other.RegionName)
		{
			return false;
		}
		if (Unk1 != other.Unk1)
		{
			return false;
		}
		if (ExResourceUrl != other.ExResourceUrl)
		{
			return false;
		}
		if (AssetBundleUrl != other.AssetBundleUrl)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Unk2 != other.Unk2)
		{
			return false;
		}
		if (Msg != other.Msg)
		{
			return false;
		}
		if (Unk3 != other.Unk3)
		{
			return false;
		}
		if (Unk4 != other.Unk4)
		{
			return false;
		}
		if (Unk10 != other.Unk10)
		{
			return false;
		}
		if (Unk5 != other.Unk5)
		{
			return false;
		}
		if (Unk6 != other.Unk6)
		{
			return false;
		}
		if (Unk14 != other.Unk14)
		{
			return false;
		}
		if (Unk13 != other.Unk13)
		{
			return false;
		}
		if (Unk7 != other.Unk7)
		{
			return false;
		}
		if (Unk8 != other.Unk8)
		{
			return false;
		}
		if (Unk15 != other.Unk15)
		{
			return false;
		}
		if (Unk16 != other.Unk16)
		{
			return false;
		}
		if (IfixVersion != other.IfixVersion)
		{
			return false;
		}
		if (MdkResVersion != other.MdkResVersion)
		{
			return false;
		}
		if (Unk12 != other.Unk12)
		{
			return false;
		}
		if (AssetBundleUrlAndroid != other.AssetBundleUrlAndroid)
		{
			return false;
		}
		if (Unk11 != other.Unk11)
		{
			return false;
		}
		if (IfixUrl != other.IfixUrl)
		{
			return false;
		}
		if (Unk9 != other.Unk9)
		{
			return false;
		}
		if (ClientSecretKey != other.ClientSecretKey)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (Ip.Length != 0)
		{
			num ^= Ip.GetHashCode();
		}
		if (LuaUrl.Length != 0)
		{
			num ^= LuaUrl.GetHashCode();
		}
		if (Port != 0)
		{
			num ^= Port.GetHashCode();
		}
		if (RegionName.Length != 0)
		{
			num ^= RegionName.GetHashCode();
		}
		if (Unk1)
		{
			num ^= Unk1.GetHashCode();
		}
		if (ExResourceUrl.Length != 0)
		{
			num ^= ExResourceUrl.GetHashCode();
		}
		if (AssetBundleUrl.Length != 0)
		{
			num ^= AssetBundleUrl.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (Unk2)
		{
			num ^= Unk2.GetHashCode();
		}
		if (Msg.Length != 0)
		{
			num ^= Msg.GetHashCode();
		}
		if (Unk3)
		{
			num ^= Unk3.GetHashCode();
		}
		if (Unk4)
		{
			num ^= Unk4.GetHashCode();
		}
		if (Unk10)
		{
			num ^= Unk10.GetHashCode();
		}
		if (Unk5)
		{
			num ^= Unk5.GetHashCode();
		}
		if (Unk6)
		{
			num ^= Unk6.GetHashCode();
		}
		if (Unk14)
		{
			num ^= Unk14.GetHashCode();
		}
		if (Unk13)
		{
			num ^= Unk13.GetHashCode();
		}
		if (Unk7)
		{
			num ^= Unk7.GetHashCode();
		}
		if (Unk8)
		{
			num ^= Unk8.GetHashCode();
		}
		if (Unk15)
		{
			num ^= Unk15.GetHashCode();
		}
		if (Unk16)
		{
			num ^= Unk16.GetHashCode();
		}
		if (IfixVersion.Length != 0)
		{
			num ^= IfixVersion.GetHashCode();
		}
		if (MdkResVersion.Length != 0)
		{
			num ^= MdkResVersion.GetHashCode();
		}
		if (Unk12)
		{
			num ^= Unk12.GetHashCode();
		}
		if (AssetBundleUrlAndroid.Length != 0)
		{
			num ^= AssetBundleUrlAndroid.GetHashCode();
		}
		if (Unk11)
		{
			num ^= Unk11.GetHashCode();
		}
		if (IfixUrl.Length != 0)
		{
			num ^= IfixUrl.GetHashCode();
		}
		if (Unk9)
		{
			num ^= Unk9.GetHashCode();
		}
		if (ClientSecretKey.Length != 0)
		{
			num ^= ClientSecretKey.GetHashCode();
		}
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (Ip.Length != 0)
		{
			output.WriteRawTag(26);
			output.WriteString(Ip);
		}
		if (LuaUrl.Length != 0)
		{
			output.WriteRawTag(50);
			output.WriteString(LuaUrl);
		}
		if (Port != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Port);
		}
		if (RegionName.Length != 0)
		{
			output.WriteRawTag(74);
			output.WriteString(RegionName);
		}
		if (Unk1)
		{
			output.WriteRawTag(80);
			output.WriteBool(Unk1);
		}
		if (ExResourceUrl.Length != 0)
		{
			output.WriteRawTag(90);
			output.WriteString(ExResourceUrl);
		}
		if (AssetBundleUrl.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(AssetBundleUrl);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (Unk2)
		{
			output.WriteRawTag(120);
			output.WriteBool(Unk2);
		}
		if (Msg.Length != 0)
		{
			output.WriteRawTag(218, 2);
			output.WriteString(Msg);
		}
		if (Unk3)
		{
			output.WriteRawTag(152, 4);
			output.WriteBool(Unk3);
		}
		if (Unk4)
		{
			output.WriteRawTag(248, 4);
			output.WriteBool(Unk4);
		}
		if (Unk10)
		{
			output.WriteRawTag(128, 7);
			output.WriteBool(Unk10);
		}
		if (Unk5)
		{
			output.WriteRawTag(192, 11);
			output.WriteBool(Unk5);
		}
		if (Unk6)
		{
			output.WriteRawTag(192, 12);
			output.WriteBool(Unk6);
		}
		if (Unk14)
		{
			output.WriteRawTag(128, 13);
			output.WriteBool(Unk14);
		}
		if (Unk13)
		{
			output.WriteRawTag(200, 24);
			output.WriteBool(Unk13);
		}
		if (Unk7)
		{
			output.WriteRawTag(176, 28);
			output.WriteBool(Unk7);
		}
		if (Unk8)
		{
			output.WriteRawTag(136, 33);
			output.WriteBool(Unk8);
		}
		if (ClientSecretKey.Length != 0)
		{
			output.WriteRawTag(138, 45);
			output.WriteString(ClientSecretKey);
		}
		if (Unk15)
		{
			output.WriteRawTag(136, 58);
			output.WriteBool(Unk15);
		}
		if (Unk16)
		{
			output.WriteRawTag(248, 60);
			output.WriteBool(Unk16);
		}
		if (IfixVersion.Length != 0)
		{
			output.WriteRawTag(210, 73);
			output.WriteString(IfixVersion);
		}
		if (MdkResVersion.Length != 0)
		{
			output.WriteRawTag(178, 77);
			output.WriteString(MdkResVersion);
		}
		if (Unk12)
		{
			output.WriteRawTag(224, 79);
			output.WriteBool(Unk12);
		}
		if (AssetBundleUrlAndroid.Length != 0)
		{
			output.WriteRawTag(202, 88);
			output.WriteString(AssetBundleUrlAndroid);
		}
		if (Unk11)
		{
			output.WriteRawTag(128, 90);
			output.WriteBool(Unk11);
		}
		if (IfixUrl.Length != 0)
		{
			output.WriteRawTag(130, 93);
			output.WriteString(IfixUrl);
		}
		if (Unk9)
		{
			output.WriteRawTag(176, 105);
			output.WriteBool(Unk9);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (Ip.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Ip);
		}
		if (LuaUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(LuaUrl);
		}
		if (Port != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Port);
		}
		if (RegionName.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(RegionName);
		}
		if (Unk1)
		{
			num += 2;
		}
		if (ExResourceUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ExResourceUrl);
		}
		if (AssetBundleUrl.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(AssetBundleUrl);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (Unk2)
		{
			num += 2;
		}
		if (Msg.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(Msg);
		}
		if (Unk3)
		{
			num += 3;
		}
		if (Unk4)
		{
			num += 3;
		}
		if (Unk10)
		{
			num += 3;
		}
		if (Unk5)
		{
			num += 3;
		}
		if (Unk6)
		{
			num += 3;
		}
		if (Unk14)
		{
			num += 3;
		}
		if (Unk13)
		{
			num += 3;
		}
		if (Unk7)
		{
			num += 3;
		}
		if (Unk8)
		{
			num += 3;
		}
		if (Unk15)
		{
			num += 3;
		}
		if (Unk16)
		{
			num += 3;
		}
		if (IfixVersion.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(IfixVersion);
		}
		if (MdkResVersion.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(MdkResVersion);
		}
		if (Unk12)
		{
			num += 3;
		}
		if (AssetBundleUrlAndroid.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(AssetBundleUrlAndroid);
		}
		if (Unk11)
		{
			num += 3;
		}
		if (IfixUrl.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(IfixUrl);
		}
		if (Unk9)
		{
			num += 3;
		}
		if (ClientSecretKey.Length != 0)
		{
			num += 2 + CodedOutputStream.ComputeStringSize(ClientSecretKey);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GateServer other)
	{
		if (other != null)
		{
			if (other.Ip.Length != 0)
			{
				Ip = other.Ip;
			}
			if (other.LuaUrl.Length != 0)
			{
				LuaUrl = other.LuaUrl;
			}
			if (other.Port != 0)
			{
				Port = other.Port;
			}
			if (other.RegionName.Length != 0)
			{
				RegionName = other.RegionName;
			}
			if (other.Unk1)
			{
				Unk1 = other.Unk1;
			}
			if (other.ExResourceUrl.Length != 0)
			{
				ExResourceUrl = other.ExResourceUrl;
			}
			if (other.AssetBundleUrl.Length != 0)
			{
				AssetBundleUrl = other.AssetBundleUrl;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.Unk2)
			{
				Unk2 = other.Unk2;
			}
			if (other.Msg.Length != 0)
			{
				Msg = other.Msg;
			}
			if (other.Unk3)
			{
				Unk3 = other.Unk3;
			}
			if (other.Unk4)
			{
				Unk4 = other.Unk4;
			}
			if (other.Unk10)
			{
				Unk10 = other.Unk10;
			}
			if (other.Unk5)
			{
				Unk5 = other.Unk5;
			}
			if (other.Unk6)
			{
				Unk6 = other.Unk6;
			}
			if (other.Unk14)
			{
				Unk14 = other.Unk14;
			}
			if (other.Unk13)
			{
				Unk13 = other.Unk13;
			}
			if (other.Unk7)
			{
				Unk7 = other.Unk7;
			}
			if (other.Unk8)
			{
				Unk8 = other.Unk8;
			}
			if (other.Unk15)
			{
				Unk15 = other.Unk15;
			}
			if (other.Unk16)
			{
				Unk16 = other.Unk16;
			}
			if (other.IfixVersion.Length != 0)
			{
				IfixVersion = other.IfixVersion;
			}
			if (other.MdkResVersion.Length != 0)
			{
				MdkResVersion = other.MdkResVersion;
			}
			if (other.Unk12)
			{
				Unk12 = other.Unk12;
			}
			if (other.AssetBundleUrlAndroid.Length != 0)
			{
				AssetBundleUrlAndroid = other.AssetBundleUrlAndroid;
			}
			if (other.Unk11)
			{
				Unk11 = other.Unk11;
			}
			if (other.IfixUrl.Length != 0)
			{
				IfixUrl = other.IfixUrl;
			}
			if (other.Unk9)
			{
				Unk9 = other.Unk9;
			}
			if (other.ClientSecretKey.Length != 0)
			{
				ClientSecretKey = other.ClientSecretKey;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
				Ip = input.ReadString();
				break;
			case 50u:
				LuaUrl = input.ReadString();
				break;
			case 56u:
				Port = input.ReadUInt32();
				break;
			case 74u:
				RegionName = input.ReadString();
				break;
			case 80u:
				Unk1 = input.ReadBool();
				break;
			case 90u:
				ExResourceUrl = input.ReadString();
				break;
			case 98u:
				AssetBundleUrl = input.ReadString();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				Unk2 = input.ReadBool();
				break;
			case 346u:
				Msg = input.ReadString();
				break;
			case 536u:
				Unk3 = input.ReadBool();
				break;
			case 632u:
				Unk4 = input.ReadBool();
				break;
			case 896u:
				Unk10 = input.ReadBool();
				break;
			case 1472u:
				Unk5 = input.ReadBool();
				break;
			case 1600u:
				Unk6 = input.ReadBool();
				break;
			case 1664u:
				Unk14 = input.ReadBool();
				break;
			case 3144u:
				Unk13 = input.ReadBool();
				break;
			case 3632u:
				Unk7 = input.ReadBool();
				break;
			case 4232u:
				Unk8 = input.ReadBool();
				break;
			case 5770u:
				ClientSecretKey = input.ReadString();
				break;
			case 7432u:
				Unk15 = input.ReadBool();
				break;
			case 7800u:
				Unk16 = input.ReadBool();
				break;
			case 9426u:
				IfixVersion = input.ReadString();
				break;
			case 9906u:
				MdkResVersion = input.ReadString();
				break;
			case 10208u:
				Unk12 = input.ReadBool();
				break;
			case 11338u:
				AssetBundleUrlAndroid = input.ReadString();
				break;
			case 11520u:
				Unk11 = input.ReadBool();
				break;
			case 11906u:
				IfixUrl = input.ReadString();
				break;
			case 13488u:
				Unk9 = input.ReadBool();
				break;
			}
		}
	}
}
