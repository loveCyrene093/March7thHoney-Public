using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GBPBMFCODPF : IMessage<GBPBMFCODPF>, IMessage, IEquatable<GBPBMFCODPF>, IDeepCloneable<GBPBMFCODPF>, IBufferMessage
{
	private static readonly MessageParser<GBPBMFCODPF> _parser = new MessageParser<GBPBMFCODPF>(() => new GBPBMFCODPF());

	private UnknownFieldSet _unknownFields;

	public const int OMECJGGLAGDFieldNumber = 7;

	private static readonly FieldCodec<uint> _repeated_oMECJGGLAGD_codec = FieldCodec.ForUInt32(58u);

	private readonly RepeatedField<uint> oMECJGGLAGD_ = new RepeatedField<uint>();

	public const int DAPINPMMFLBFieldNumber = 8;

	private static readonly FieldCodec<uint> _repeated_dAPINPMMFLB_codec = FieldCodec.ForUInt32(66u);

	private readonly RepeatedField<uint> dAPINPMMFLB_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GBPBMFCODPF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GBPBMFCODPFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> OMECJGGLAGD => oMECJGGLAGD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> DAPINPMMFLB => dAPINPMMFLB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBPBMFCODPF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBPBMFCODPF(GBPBMFCODPF other)
		: this()
	{
		oMECJGGLAGD_ = other.oMECJGGLAGD_.Clone();
		dAPINPMMFLB_ = other.dAPINPMMFLB_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GBPBMFCODPF Clone()
	{
		return new GBPBMFCODPF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GBPBMFCODPF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GBPBMFCODPF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!oMECJGGLAGD_.Equals(other.oMECJGGLAGD_))
		{
			return false;
		}
		if (!dAPINPMMFLB_.Equals(other.dAPINPMMFLB_))
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
		num ^= oMECJGGLAGD_.GetHashCode();
		num ^= dAPINPMMFLB_.GetHashCode();
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
		oMECJGGLAGD_.WriteTo(ref output, _repeated_oMECJGGLAGD_codec);
		dAPINPMMFLB_.WriteTo(ref output, _repeated_dAPINPMMFLB_codec);
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
		num += oMECJGGLAGD_.CalculateSize(_repeated_oMECJGGLAGD_codec);
		num += dAPINPMMFLB_.CalculateSize(_repeated_dAPINPMMFLB_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GBPBMFCODPF other)
	{
		if (other != null)
		{
			oMECJGGLAGD_.Add(other.oMECJGGLAGD_);
			dAPINPMMFLB_.Add(other.dAPINPMMFLB_);
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
			case 56u:
			case 58u:
				oMECJGGLAGD_.AddEntriesFrom(ref input, _repeated_oMECJGGLAGD_codec);
				break;
			case 64u:
			case 66u:
				dAPINPMMFLB_.AddEntriesFrom(ref input, _repeated_dAPINPMMFLB_codec);
				break;
			}
		}
	}
}
