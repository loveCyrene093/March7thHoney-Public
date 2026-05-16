using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FinishChenLingGameBoyScRsp : IMessage<FinishChenLingGameBoyScRsp>, IMessage, IEquatable<FinishChenLingGameBoyScRsp>, IDeepCloneable<FinishChenLingGameBoyScRsp>, IBufferMessage
{
	private static readonly MessageParser<FinishChenLingGameBoyScRsp> _parser = new MessageParser<FinishChenLingGameBoyScRsp>(() => new FinishChenLingGameBoyScRsp());

	private UnknownFieldSet _unknownFields;

	public const int ICMKGFLBEJPFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_iCMKGFLBEJP_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> iCMKGFLBEJP_ = new RepeatedField<uint>();

	public const int GPJHJOOIJJCFieldNumber = 4;

	private uint gPJHJOOIJJC_;

	public const int GIAOIMOFALHFieldNumber = 6;

	private ulong gIAOIMOFALH_;

	public const int HHKCADKCLJCFieldNumber = 11;

	private ulong hHKCADKCLJC_;

	public const int RewardFieldNumber = 12;

	private ItemList reward_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FinishChenLingGameBoyScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FinishChenLingGameBoyScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> ICMKGFLBEJP => iCMKGFLBEJP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJHJOOIJJC
	{
		get
		{
			return gPJHJOOIJJC_;
		}
		set
		{
			gPJHJOOIJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong GIAOIMOFALH
	{
		get
		{
			return gIAOIMOFALH_;
		}
		set
		{
			gIAOIMOFALH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HHKCADKCLJC
	{
		get
		{
			return hHKCADKCLJC_;
		}
		set
		{
			hHKCADKCLJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList Reward
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
	public FinishChenLingGameBoyScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChenLingGameBoyScRsp(FinishChenLingGameBoyScRsp other)
		: this()
	{
		iCMKGFLBEJP_ = other.iCMKGFLBEJP_.Clone();
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		gIAOIMOFALH_ = other.gIAOIMOFALH_;
		hHKCADKCLJC_ = other.hHKCADKCLJC_;
		reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FinishChenLingGameBoyScRsp Clone()
	{
		return new FinishChenLingGameBoyScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FinishChenLingGameBoyScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FinishChenLingGameBoyScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iCMKGFLBEJP_.Equals(other.iCMKGFLBEJP_))
		{
			return false;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
		{
			return false;
		}
		if (GIAOIMOFALH != other.GIAOIMOFALH)
		{
			return false;
		}
		if (HHKCADKCLJC != other.HHKCADKCLJC)
		{
			return false;
		}
		if (!object.Equals(Reward, other.Reward))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		num ^= iCMKGFLBEJP_.GetHashCode();
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
		}
		if (GIAOIMOFALH != 0L)
		{
			num ^= GIAOIMOFALH.GetHashCode();
		}
		if (HHKCADKCLJC != 0L)
		{
			num ^= HHKCADKCLJC.GetHashCode();
		}
		if (reward_ != null)
		{
			num ^= Reward.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		iCMKGFLBEJP_.WriteTo(ref output, _repeated_iCMKGFLBEJP_codec);
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GPJHJOOIJJC);
		}
		if (GIAOIMOFALH != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(GIAOIMOFALH);
		}
		if (HHKCADKCLJC != 0L)
		{
			output.WriteRawTag(88);
			output.WriteUInt64(HHKCADKCLJC);
		}
		if (reward_ != null)
		{
			output.WriteRawTag(98);
			output.WriteMessage(Reward);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
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
		num += iCMKGFLBEJP_.CalculateSize(_repeated_iCMKGFLBEJP_codec);
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (GIAOIMOFALH != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(GIAOIMOFALH);
		}
		if (HHKCADKCLJC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HHKCADKCLJC);
		}
		if (reward_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Reward);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FinishChenLingGameBoyScRsp other)
	{
		if (other == null)
		{
			return;
		}
		iCMKGFLBEJP_.Add(other.iCMKGFLBEJP_);
		if (other.GPJHJOOIJJC != 0)
		{
			GPJHJOOIJJC = other.GPJHJOOIJJC;
		}
		if (other.GIAOIMOFALH != 0L)
		{
			GIAOIMOFALH = other.GIAOIMOFALH;
		}
		if (other.HHKCADKCLJC != 0L)
		{
			HHKCADKCLJC = other.HHKCADKCLJC;
		}
		if (other.reward_ != null)
		{
			if (reward_ == null)
			{
				Reward = new ItemList();
			}
			Reward.MergeFrom(other.Reward);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			case 16u:
			case 18u:
				iCMKGFLBEJP_.AddEntriesFrom(ref input, _repeated_iCMKGFLBEJP_codec);
				break;
			case 32u:
				GPJHJOOIJJC = input.ReadUInt32();
				break;
			case 48u:
				GIAOIMOFALH = input.ReadUInt64();
				break;
			case 88u:
				HHKCADKCLJC = input.ReadUInt64();
				break;
			case 98u:
				if (reward_ == null)
				{
					Reward = new ItemList();
				}
				input.ReadMessage(Reward);
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
