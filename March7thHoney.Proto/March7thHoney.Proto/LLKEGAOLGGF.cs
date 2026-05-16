using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LLKEGAOLGGF : IMessage<LLKEGAOLGGF>, IMessage, IEquatable<LLKEGAOLGGF>, IDeepCloneable<LLKEGAOLGGF>, IBufferMessage
{
	private static readonly MessageParser<LLKEGAOLGGF> _parser = new MessageParser<LLKEGAOLGGF>(() => new LLKEGAOLGGF());

	private UnknownFieldSet _unknownFields;

	public const int NKJHKMBLIBLFieldNumber = 1;

	private static readonly FieldCodec<PPDPDGCBDEH> _repeated_nKJHKMBLIBL_codec = FieldCodec.ForMessage(10u, PPDPDGCBDEH.Parser);

	private readonly RepeatedField<PPDPDGCBDEH> nKJHKMBLIBL_ = new RepeatedField<PPDPDGCBDEH>();

	public const int IFEJLJCINCIFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_iFEJLJCINCI_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> iFEJLJCINCI_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LLKEGAOLGGF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LLKEGAOLGGFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PPDPDGCBDEH> NKJHKMBLIBL => nKJHKMBLIBL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IFEJLJCINCI => iFEJLJCINCI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLKEGAOLGGF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLKEGAOLGGF(LLKEGAOLGGF other)
		: this()
	{
		nKJHKMBLIBL_ = other.nKJHKMBLIBL_.Clone();
		iFEJLJCINCI_ = other.iFEJLJCINCI_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLKEGAOLGGF Clone()
	{
		return new LLKEGAOLGGF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LLKEGAOLGGF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LLKEGAOLGGF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!nKJHKMBLIBL_.Equals(other.nKJHKMBLIBL_))
		{
			return false;
		}
		if (!iFEJLJCINCI_.Equals(other.iFEJLJCINCI_))
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
		num ^= nKJHKMBLIBL_.GetHashCode();
		num ^= iFEJLJCINCI_.GetHashCode();
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
		nKJHKMBLIBL_.WriteTo(ref output, _repeated_nKJHKMBLIBL_codec);
		iFEJLJCINCI_.WriteTo(ref output, _repeated_iFEJLJCINCI_codec);
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
		num += nKJHKMBLIBL_.CalculateSize(_repeated_nKJHKMBLIBL_codec);
		num += iFEJLJCINCI_.CalculateSize(_repeated_iFEJLJCINCI_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LLKEGAOLGGF other)
	{
		if (other != null)
		{
			nKJHKMBLIBL_.Add(other.nKJHKMBLIBL_);
			iFEJLJCINCI_.Add(other.iFEJLJCINCI_);
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
			case 10u:
				nKJHKMBLIBL_.AddEntriesFrom(ref input, _repeated_nKJHKMBLIBL_codec);
				break;
			case 72u:
			case 74u:
				iFEJLJCINCI_.AddEntriesFrom(ref input, _repeated_iFEJLJCINCI_codec);
				break;
			}
		}
	}
}
