using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChenLingGameBoyGetFriendRankingInfoScRsp : IMessage<ChenLingGameBoyGetFriendRankingInfoScRsp>, IMessage, IEquatable<ChenLingGameBoyGetFriendRankingInfoScRsp>, IDeepCloneable<ChenLingGameBoyGetFriendRankingInfoScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChenLingGameBoyGetFriendRankingInfoScRsp> _parser = new MessageParser<ChenLingGameBoyGetFriendRankingInfoScRsp>(() => new ChenLingGameBoyGetFriendRankingInfoScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JPNALKEFHOHFieldNumber = 8;

	private static readonly FieldCodec<PCMHMCLACNK> _repeated_jPNALKEFHOH_codec = FieldCodec.ForMessage(66u, PCMHMCLACNK.Parser);

	private readonly RepeatedField<PCMHMCLACNK> jPNALKEFHOH_ = new RepeatedField<PCMHMCLACNK>();

	public const int KEPMJKGJLNJFieldNumber = 12;

	private bool kEPMJKGJLNJ_;

	public const int RetcodeFieldNumber = 13;

	private uint retcode_;

	public const int GPJHJOOIJJCFieldNumber = 15;

	private uint gPJHJOOIJJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChenLingGameBoyGetFriendRankingInfoScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChenLingGameBoyGetFriendRankingInfoScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PCMHMCLACNK> JPNALKEFHOH => jPNALKEFHOH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool KEPMJKGJLNJ
	{
		get
		{
			return kEPMJKGJLNJ_;
		}
		set
		{
			kEPMJKGJLNJ_ = value;
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
	public ChenLingGameBoyGetFriendRankingInfoScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingGameBoyGetFriendRankingInfoScRsp(ChenLingGameBoyGetFriendRankingInfoScRsp other)
		: this()
	{
		jPNALKEFHOH_ = other.jPNALKEFHOH_.Clone();
		kEPMJKGJLNJ_ = other.kEPMJKGJLNJ_;
		retcode_ = other.retcode_;
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChenLingGameBoyGetFriendRankingInfoScRsp Clone()
	{
		return new ChenLingGameBoyGetFriendRankingInfoScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChenLingGameBoyGetFriendRankingInfoScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChenLingGameBoyGetFriendRankingInfoScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!jPNALKEFHOH_.Equals(other.jPNALKEFHOH_))
		{
			return false;
		}
		if (KEPMJKGJLNJ != other.KEPMJKGJLNJ)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
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
		num ^= jPNALKEFHOH_.GetHashCode();
		if (KEPMJKGJLNJ)
		{
			num ^= KEPMJKGJLNJ.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
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
		jPNALKEFHOH_.WriteTo(ref output, _repeated_jPNALKEFHOH_codec);
		if (KEPMJKGJLNJ)
		{
			output.WriteRawTag(96);
			output.WriteBool(KEPMJKGJLNJ);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(Retcode);
		}
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(GPJHJOOIJJC);
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
		num += jPNALKEFHOH_.CalculateSize(_repeated_jPNALKEFHOH_codec);
		if (KEPMJKGJLNJ)
		{
			num += 2;
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChenLingGameBoyGetFriendRankingInfoScRsp other)
	{
		if (other != null)
		{
			jPNALKEFHOH_.Add(other.jPNALKEFHOH_);
			if (other.KEPMJKGJLNJ)
			{
				KEPMJKGJLNJ = other.KEPMJKGJLNJ;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.GPJHJOOIJJC != 0)
			{
				GPJHJOOIJJC = other.GPJHJOOIJJC;
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
			case 66u:
				jPNALKEFHOH_.AddEntriesFrom(ref input, _repeated_jPNALKEFHOH_codec);
				break;
			case 96u:
				KEPMJKGJLNJ = input.ReadBool();
				break;
			case 104u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				GPJHJOOIJJC = input.ReadUInt32();
				break;
			}
		}
	}
}
