using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EraFlipperDataList : IMessage<EraFlipperDataList>, IMessage, IEquatable<EraFlipperDataList>, IDeepCloneable<EraFlipperDataList>, IBufferMessage
{
	private static readonly MessageParser<EraFlipperDataList> _parser = new MessageParser<EraFlipperDataList>(() => new EraFlipperDataList());

	private UnknownFieldSet _unknownFields;

	public const int CDPFCPCILOFFieldNumber = 11;

	private static readonly FieldCodec<BIDGPELJPJK> _repeated_cDPFCPCILOF_codec = FieldCodec.ForMessage(90u, BIDGPELJPJK.Parser);

	private readonly RepeatedField<BIDGPELJPJK> cDPFCPCILOF_ = new RepeatedField<BIDGPELJPJK>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EraFlipperDataList> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EraFlipperDataListReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<BIDGPELJPJK> CDPFCPCILOF => cDPFCPCILOF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataList()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataList(EraFlipperDataList other)
		: this()
	{
		cDPFCPCILOF_ = other.cDPFCPCILOF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataList Clone()
	{
		return new EraFlipperDataList(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EraFlipperDataList);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EraFlipperDataList other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cDPFCPCILOF_.Equals(other.cDPFCPCILOF_))
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
		num ^= cDPFCPCILOF_.GetHashCode();
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
		cDPFCPCILOF_.WriteTo(ref output, _repeated_cDPFCPCILOF_codec);
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
		num += cDPFCPCILOF_.CalculateSize(_repeated_cDPFCPCILOF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EraFlipperDataList other)
	{
		if (other != null)
		{
			cDPFCPCILOF_.Add(other.cDPFCPCILOF_);
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
			if (num != 90)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cDPFCPCILOF_.AddEntriesFrom(ref input, _repeated_cDPFCPCILOF_codec);
			}
		}
	}
}
