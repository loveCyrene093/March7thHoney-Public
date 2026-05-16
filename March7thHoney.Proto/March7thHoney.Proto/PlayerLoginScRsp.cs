using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayerLoginScRsp : IMessage<PlayerLoginScRsp>, IMessage, IEquatable<PlayerLoginScRsp>, IDeepCloneable<PlayerLoginScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlayerLoginScRsp> _parser = new MessageParser<PlayerLoginScRsp>(() => new PlayerLoginScRsp());

	private UnknownFieldSet _unknownFields;

	public const int BasicInfoFieldNumber = 1;

	private PlayerBasicInfo basicInfo_;

	public const int LoginRandomFieldNumber = 4;

	private ulong loginRandom_;

	public const int StaminaFieldNumber = 7;

	private uint stamina_;

	public const int ServerTimestampMsFieldNumber = 8;

	private ulong serverTimestampMs_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int PJNKEEOKGBOFieldNumber = 10;

	private string pJNKEEOKGBO_ = "";

	public const int CurTimezoneFieldNumber = 11;

	private int curTimezone_;

	public const int ICHLJDLEPNLFieldNumber = 12;

	private string iCHLJDLEPNL_ = "";

	public const int CIGNEJKDKJFFieldNumber = 13;

	private bool cIGNEJKDKJF_;

	public const int ALLHDAFGDCJFieldNumber = 14;

	private bool aLLHDAFGDCJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayerLoginScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayerLoginScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerBasicInfo BasicInfo
	{
		get
		{
			return basicInfo_;
		}
		set
		{
			basicInfo_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong LoginRandom
	{
		get
		{
			return loginRandom_;
		}
		set
		{
			loginRandom_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Stamina
	{
		get
		{
			return stamina_;
		}
		set
		{
			stamina_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong ServerTimestampMs
	{
		get
		{
			return serverTimestampMs_;
		}
		set
		{
			serverTimestampMs_ = value;
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
	public string PJNKEEOKGBO
	{
		get
		{
			return pJNKEEOKGBO_;
		}
		set
		{
			pJNKEEOKGBO_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurTimezone
	{
		get
		{
			return curTimezone_;
		}
		set
		{
			curTimezone_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ICHLJDLEPNL
	{
		get
		{
			return iCHLJDLEPNL_;
		}
		set
		{
			iCHLJDLEPNL_ = ProtoPreconditions.CheckNotNull(value, "value");
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CIGNEJKDKJF
	{
		get
		{
			return cIGNEJKDKJF_;
		}
		set
		{
			cIGNEJKDKJF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ALLHDAFGDCJ
	{
		get
		{
			return aLLHDAFGDCJ_;
		}
		set
		{
			aLLHDAFGDCJ_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerLoginScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerLoginScRsp(PlayerLoginScRsp other)
		: this()
	{
		basicInfo_ = ((other.basicInfo_ != null) ? other.basicInfo_.Clone() : null);
		loginRandom_ = other.loginRandom_;
		stamina_ = other.stamina_;
		serverTimestampMs_ = other.serverTimestampMs_;
		retcode_ = other.retcode_;
		pJNKEEOKGBO_ = other.pJNKEEOKGBO_;
		curTimezone_ = other.curTimezone_;
		iCHLJDLEPNL_ = other.iCHLJDLEPNL_;
		cIGNEJKDKJF_ = other.cIGNEJKDKJF_;
		aLLHDAFGDCJ_ = other.aLLHDAFGDCJ_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerLoginScRsp Clone()
	{
		return new PlayerLoginScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayerLoginScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayerLoginScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BasicInfo, other.BasicInfo))
		{
			return false;
		}
		if (LoginRandom != other.LoginRandom)
		{
			return false;
		}
		if (Stamina != other.Stamina)
		{
			return false;
		}
		if (ServerTimestampMs != other.ServerTimestampMs)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (PJNKEEOKGBO != other.PJNKEEOKGBO)
		{
			return false;
		}
		if (CurTimezone != other.CurTimezone)
		{
			return false;
		}
		if (ICHLJDLEPNL != other.ICHLJDLEPNL)
		{
			return false;
		}
		if (CIGNEJKDKJF != other.CIGNEJKDKJF)
		{
			return false;
		}
		if (ALLHDAFGDCJ != other.ALLHDAFGDCJ)
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
		if (basicInfo_ != null)
		{
			num ^= BasicInfo.GetHashCode();
		}
		if (LoginRandom != 0L)
		{
			num ^= LoginRandom.GetHashCode();
		}
		if (Stamina != 0)
		{
			num ^= Stamina.GetHashCode();
		}
		if (ServerTimestampMs != 0L)
		{
			num ^= ServerTimestampMs.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (PJNKEEOKGBO.Length != 0)
		{
			num ^= PJNKEEOKGBO.GetHashCode();
		}
		if (CurTimezone != 0)
		{
			num ^= CurTimezone.GetHashCode();
		}
		if (ICHLJDLEPNL.Length != 0)
		{
			num ^= ICHLJDLEPNL.GetHashCode();
		}
		if (CIGNEJKDKJF)
		{
			num ^= CIGNEJKDKJF.GetHashCode();
		}
		if (ALLHDAFGDCJ)
		{
			num ^= ALLHDAFGDCJ.GetHashCode();
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
		if (basicInfo_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(BasicInfo);
		}
		if (LoginRandom != 0L)
		{
			output.WriteRawTag(32);
			output.WriteUInt64(LoginRandom);
		}
		if (Stamina != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(Stamina);
		}
		if (ServerTimestampMs != 0L)
		{
			output.WriteRawTag(64);
			output.WriteUInt64(ServerTimestampMs);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (PJNKEEOKGBO.Length != 0)
		{
			output.WriteRawTag(82);
			output.WriteString(PJNKEEOKGBO);
		}
		if (CurTimezone != 0)
		{
			output.WriteRawTag(88);
			output.WriteInt32(CurTimezone);
		}
		if (ICHLJDLEPNL.Length != 0)
		{
			output.WriteRawTag(98);
			output.WriteString(ICHLJDLEPNL);
		}
		if (CIGNEJKDKJF)
		{
			output.WriteRawTag(104);
			output.WriteBool(CIGNEJKDKJF);
		}
		if (ALLHDAFGDCJ)
		{
			output.WriteRawTag(112);
			output.WriteBool(ALLHDAFGDCJ);
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
		if (basicInfo_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BasicInfo);
		}
		if (LoginRandom != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(LoginRandom);
		}
		if (Stamina != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Stamina);
		}
		if (ServerTimestampMs != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(ServerTimestampMs);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (PJNKEEOKGBO.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(PJNKEEOKGBO);
		}
		if (CurTimezone != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(CurTimezone);
		}
		if (ICHLJDLEPNL.Length != 0)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(ICHLJDLEPNL);
		}
		if (CIGNEJKDKJF)
		{
			num += 2;
		}
		if (ALLHDAFGDCJ)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayerLoginScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.basicInfo_ != null)
		{
			if (basicInfo_ == null)
			{
				BasicInfo = new PlayerBasicInfo();
			}
			BasicInfo.MergeFrom(other.BasicInfo);
		}
		if (other.LoginRandom != 0L)
		{
			LoginRandom = other.LoginRandom;
		}
		if (other.Stamina != 0)
		{
			Stamina = other.Stamina;
		}
		if (other.ServerTimestampMs != 0L)
		{
			ServerTimestampMs = other.ServerTimestampMs;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.PJNKEEOKGBO.Length != 0)
		{
			PJNKEEOKGBO = other.PJNKEEOKGBO;
		}
		if (other.CurTimezone != 0)
		{
			CurTimezone = other.CurTimezone;
		}
		if (other.ICHLJDLEPNL.Length != 0)
		{
			ICHLJDLEPNL = other.ICHLJDLEPNL;
		}
		if (other.CIGNEJKDKJF)
		{
			CIGNEJKDKJF = other.CIGNEJKDKJF;
		}
		if (other.ALLHDAFGDCJ)
		{
			ALLHDAFGDCJ = other.ALLHDAFGDCJ;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
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
			case 10u:
				if (basicInfo_ == null)
				{
					BasicInfo = new PlayerBasicInfo();
				}
				input.ReadMessage(BasicInfo);
				break;
			case 32u:
				LoginRandom = input.ReadUInt64();
				break;
			case 56u:
				Stamina = input.ReadUInt32();
				break;
			case 64u:
				ServerTimestampMs = input.ReadUInt64();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				PJNKEEOKGBO = input.ReadString();
				break;
			case 88u:
				CurTimezone = input.ReadInt32();
				break;
			case 98u:
				ICHLJDLEPNL = input.ReadString();
				break;
			case 104u:
				CIGNEJKDKJF = input.ReadBool();
				break;
			case 112u:
				ALLHDAFGDCJ = input.ReadBool();
				break;
			}
		}
	}
}
