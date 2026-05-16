using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AHCAHFFNHLD : IMessage<AHCAHFFNHLD>, IMessage, IEquatable<AHCAHFFNHLD>, IDeepCloneable<AHCAHFFNHLD>, IBufferMessage
{
	private static readonly MessageParser<AHCAHFFNHLD> _parser = new MessageParser<AHCAHFFNHLD>(() => new AHCAHFFNHLD());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int LLFIBOHPAHBFieldNumber = 13;

	private static readonly FieldCodec<ReplayInfo> _repeated_lLFIBOHPAHB_codec = FieldCodec.ForMessage(106u, ReplayInfo.Parser);

	private readonly RepeatedField<ReplayInfo> lLFIBOHPAHB_ = new RepeatedField<ReplayInfo>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AHCAHFFNHLD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AHCAHFFNHLDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public RepeatedField<ReplayInfo> LLFIBOHPAHB => lLFIBOHPAHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHCAHFFNHLD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHCAHFFNHLD(AHCAHFFNHLD other)
		: this()
	{
		retcode_ = other.retcode_;
		lLFIBOHPAHB_ = other.lLFIBOHPAHB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AHCAHFFNHLD Clone()
	{
		return new AHCAHFFNHLD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AHCAHFFNHLD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AHCAHFFNHLD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!lLFIBOHPAHB_.Equals(other.lLFIBOHPAHB_))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		num ^= lLFIBOHPAHB_.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		lLFIBOHPAHB_.WriteTo(ref output, _repeated_lLFIBOHPAHB_codec);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		num += lLFIBOHPAHB_.CalculateSize(_repeated_lLFIBOHPAHB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AHCAHFFNHLD other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			lLFIBOHPAHB_.Add(other.lLFIBOHPAHB_);
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
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 106u:
				lLFIBOHPAHB_.AddEntriesFrom(ref input, _repeated_lLFIBOHPAHB_codec);
				break;
			}
		}
	}
}
