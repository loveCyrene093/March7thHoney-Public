using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesStartMiniGameScRsp : IMessage<PlanetFesStartMiniGameScRsp>, IMessage, IEquatable<PlanetFesStartMiniGameScRsp>, IDeepCloneable<PlanetFesStartMiniGameScRsp>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesStartMiniGameScRsp> _parser = new MessageParser<PlanetFesStartMiniGameScRsp>(() => new PlanetFesStartMiniGameScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OIAPHBBDPHLFieldNumber = 4;

	private JOJLACDBPNA oIAPHBBDPHL_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	public const int EFBAMGJDAEHFieldNumber = 8;

	private GIFNOKLKCGH eFBAMGJDAEH_;

	public const int RewardFieldNumber = 9;

	private HLLCDBLCIPK reward_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesStartMiniGameScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesStartMiniGameScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JOJLACDBPNA OIAPHBBDPHL
	{
		get
		{
			return oIAPHBBDPHL_;
		}
		set
		{
			oIAPHBBDPHL_ = value;
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
	public GIFNOKLKCGH EFBAMGJDAEH
	{
		get
		{
			return eFBAMGJDAEH_;
		}
		set
		{
			eFBAMGJDAEH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HLLCDBLCIPK Reward
	{
		get
		{
			return reward_;
		}
		set
		{
			reward_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesStartMiniGameScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesStartMiniGameScRsp(PlanetFesStartMiniGameScRsp other)
		: this()
	{
		oIAPHBBDPHL_ = ((other.oIAPHBBDPHL_ != null) ? other.oIAPHBBDPHL_.Clone() : null);
		retcode_ = other.retcode_;
		eFBAMGJDAEH_ = ((other.eFBAMGJDAEH_ != null) ? other.eFBAMGJDAEH_.Clone() : null);
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesStartMiniGameScRsp Clone()
	{
		return new PlanetFesStartMiniGameScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesStartMiniGameScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesStartMiniGameScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OIAPHBBDPHL, other.OIAPHBBDPHL))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(EFBAMGJDAEH, other.EFBAMGJDAEH))
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
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
		if (oIAPHBBDPHL_ != null)
		{
			num ^= OIAPHBBDPHL.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (eFBAMGJDAEH_ != null)
		{
			num ^= EFBAMGJDAEH.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
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
		if (oIAPHBBDPHL_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(OIAPHBBDPHL);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(Retcode);
		}
		if (eFBAMGJDAEH_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(EFBAMGJDAEH);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(Reward);
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
		if (oIAPHBBDPHL_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OIAPHBBDPHL);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (eFBAMGJDAEH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EFBAMGJDAEH);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesStartMiniGameScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oIAPHBBDPHL_ != null)
		{
			if (oIAPHBBDPHL_ == null)
			{
				OIAPHBBDPHL = new JOJLACDBPNA();
			}
			OIAPHBBDPHL.MergeFrom(other.OIAPHBBDPHL);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.eFBAMGJDAEH_ != null)
		{
			if (eFBAMGJDAEH_ == null)
			{
				EFBAMGJDAEH = new GIFNOKLKCGH();
			}
			EFBAMGJDAEH.MergeFrom(other.EFBAMGJDAEH);
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new HLLCDBLCIPK();
			}
			Reward.MergeFrom(other.Reward);
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
			case 34u:
				if (oIAPHBBDPHL_ == null)
				{
					OIAPHBBDPHL = new JOJLACDBPNA();
				}
				input.ReadMessage(OIAPHBBDPHL);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			case 66u:
				if (eFBAMGJDAEH_ == null)
				{
					EFBAMGJDAEH = new GIFNOKLKCGH();
				}
				input.ReadMessage(EFBAMGJDAEH);
				break;
			case 74u:
				if (reward_ == null)
				{
					Reward = new HLLCDBLCIPK();
				}
				input.ReadMessage(Reward);
				break;
			}
		}
	}
}
