using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KNGEFJMKLKC : IMessage<KNGEFJMKLKC>, IMessage, IEquatable<KNGEFJMKLKC>, IDeepCloneable<KNGEFJMKLKC>, IBufferMessage
{
	private static readonly MessageParser<KNGEFJMKLKC> _parser = new MessageParser<KNGEFJMKLKC>(() => new KNGEFJMKLKC());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	public const int MCLBKOHKHHBFieldNumber = 14;

	private static readonly FieldCodec<PGMMDCCGLJD> _repeated_mCLBKOHKHHB_codec = FieldCodec.ForMessage(114u, PGMMDCCGLJD.Parser);

	private readonly RepeatedField<PGMMDCCGLJD> mCLBKOHKHHB_ = new RepeatedField<PGMMDCCGLJD>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KNGEFJMKLKC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KNGEFJMKLKCReflection.Descriptor.MessageTypes[0];

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
	public RepeatedField<PGMMDCCGLJD> MCLBKOHKHHB => mCLBKOHKHHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGEFJMKLKC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGEFJMKLKC(KNGEFJMKLKC other)
		: this()
	{
		retcode_ = other.retcode_;
		mCLBKOHKHHB_ = other.mCLBKOHKHHB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KNGEFJMKLKC Clone()
	{
		return new KNGEFJMKLKC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KNGEFJMKLKC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KNGEFJMKLKC other)
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
		if (!mCLBKOHKHHB_.Equals(other.mCLBKOHKHHB_))
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
		num ^= mCLBKOHKHHB_.GetHashCode();
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
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
		}
		mCLBKOHKHHB_.WriteTo(ref output, _repeated_mCLBKOHKHHB_codec);
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
		num += mCLBKOHKHHB_.CalculateSize(_repeated_mCLBKOHKHHB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KNGEFJMKLKC other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			mCLBKOHKHHB_.Add(other.mCLBKOHKHHB_);
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
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			case 114u:
				mCLBKOHKHHB_.AddEntriesFrom(ref input, _repeated_mCLBKOHKHHB_codec);
				break;
			}
		}
	}
}
