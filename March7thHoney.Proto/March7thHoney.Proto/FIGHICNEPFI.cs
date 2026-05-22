using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FIGHICNEPFI : IMessage<FIGHICNEPFI>, IMessage, IEquatable<FIGHICNEPFI>, IDeepCloneable<FIGHICNEPFI>, IBufferMessage
{
	private static readonly MessageParser<FIGHICNEPFI> _parser = new MessageParser<FIGHICNEPFI>(() => new FIGHICNEPFI());

	private UnknownFieldSet _unknownFields;

	public const int BPEOECAGIIGFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_bPEOECAGIIG_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> bPEOECAGIIG_ = new RepeatedField<uint>();

	public const int IPDCBEMHIMGFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_iPDCBEMHIMG_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> iPDCBEMHIMG_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FIGHICNEPFI> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FIGHICNEPFIReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BPEOECAGIIG => bPEOECAGIIG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IPDCBEMHIMG => iPDCBEMHIMG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGHICNEPFI()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGHICNEPFI(FIGHICNEPFI other)
		: this()
	{
		bPEOECAGIIG_ = other.bPEOECAGIIG_.Clone();
		iPDCBEMHIMG_ = other.iPDCBEMHIMG_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FIGHICNEPFI Clone()
	{
		return new FIGHICNEPFI(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FIGHICNEPFI);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FIGHICNEPFI other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bPEOECAGIIG_.Equals(other.bPEOECAGIIG_))
		{
			return false;
		}
		if (!iPDCBEMHIMG_.Equals(other.iPDCBEMHIMG_))
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
		num ^= bPEOECAGIIG_.GetHashCode();
		num ^= iPDCBEMHIMG_.GetHashCode();
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
		bPEOECAGIIG_.WriteTo(ref output, _repeated_bPEOECAGIIG_codec);
		iPDCBEMHIMG_.WriteTo(ref output, _repeated_iPDCBEMHIMG_codec);
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
		num += bPEOECAGIIG_.CalculateSize(_repeated_bPEOECAGIIG_codec);
		num += iPDCBEMHIMG_.CalculateSize(_repeated_iPDCBEMHIMG_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FIGHICNEPFI other)
	{
		if (other != null)
		{
			bPEOECAGIIG_.Add(other.bPEOECAGIIG_);
			iPDCBEMHIMG_.Add(other.iPDCBEMHIMG_);
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
			case 8u:
			case 10u:
				bPEOECAGIIG_.AddEntriesFrom(ref input, _repeated_bPEOECAGIIG_codec);
				break;
			case 16u:
			case 18u:
				iPDCBEMHIMG_.AddEntriesFrom(ref input, _repeated_iPDCBEMHIMG_codec);
				break;
			}
		}
	}
}
