using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DLPGKJLBFLI : IMessage<DLPGKJLBFLI>, IMessage, IEquatable<DLPGKJLBFLI>, IDeepCloneable<DLPGKJLBFLI>, IBufferMessage
{
	private static readonly MessageParser<DLPGKJLBFLI> _parser = new MessageParser<DLPGKJLBFLI>(() => new DLPGKJLBFLI());

	private UnknownFieldSet _unknownFields;

	public const int FDMHNFKHGBGFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_fDMHNFKHGBG_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> fDMHNFKHGBG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DLPGKJLBFLI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DLPGKJLBFLIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> FDMHNFKHGBG => fDMHNFKHGBG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLPGKJLBFLI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLPGKJLBFLI(DLPGKJLBFLI other)
		: this()
	{
		fDMHNFKHGBG_ = other.fDMHNFKHGBG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DLPGKJLBFLI Clone()
	{
		return new DLPGKJLBFLI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DLPGKJLBFLI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DLPGKJLBFLI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!fDMHNFKHGBG_.Equals(other.fDMHNFKHGBG_))
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
		num ^= fDMHNFKHGBG_.GetHashCode();
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
		fDMHNFKHGBG_.WriteTo(ref output, _repeated_fDMHNFKHGBG_codec);
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
		num += fDMHNFKHGBG_.CalculateSize(_repeated_fDMHNFKHGBG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DLPGKJLBFLI other)
	{
		if (other != null)
		{
			fDMHNFKHGBG_.Add(other.fDMHNFKHGBG_);
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
			if (num != 64 && num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				fDMHNFKHGBG_.AddEntriesFrom(ref input, _repeated_fDMHNFKHGBG_codec);
			}
		}
	}
}
