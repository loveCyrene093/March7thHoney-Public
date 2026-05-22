using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KKNHIMGNMPG : IMessage<KKNHIMGNMPG>, IMessage, IEquatable<KKNHIMGNMPG>, IDeepCloneable<KKNHIMGNMPG>, IBufferMessage
{
	private static readonly MessageParser<KKNHIMGNMPG> _parser = new MessageParser<KKNHIMGNMPG>(() => new KKNHIMGNMPG());

	private UnknownFieldSet _unknownFields;

	public const int PFDKKFPPAAAFieldNumber = 1;

	private static readonly FieldCodec<uint> _repeated_pFDKKFPPAAA_codec = FieldCodec.ForUInt32(10u);

	private readonly RepeatedField<uint> pFDKKFPPAAA_ = new RepeatedField<uint>();

	public const int CCOAKLKBPMFFieldNumber = 2;

	private static readonly FieldCodec<uint> _repeated_cCOAKLKBPMF_codec = FieldCodec.ForUInt32(18u);

	private readonly RepeatedField<uint> cCOAKLKBPMF_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KKNHIMGNMPG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KKNHIMGNMPGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PFDKKFPPAAA => pFDKKFPPAAA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> CCOAKLKBPMF => cCOAKLKBPMF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNHIMGNMPG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNHIMGNMPG(KKNHIMGNMPG other)
		: this()
	{
		pFDKKFPPAAA_ = other.pFDKKFPPAAA_.Clone();
		cCOAKLKBPMF_ = other.cCOAKLKBPMF_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KKNHIMGNMPG Clone()
	{
		return new KKNHIMGNMPG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KKNHIMGNMPG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KKNHIMGNMPG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pFDKKFPPAAA_.Equals(other.pFDKKFPPAAA_))
		{
			return false;
		}
		if (!cCOAKLKBPMF_.Equals(other.cCOAKLKBPMF_))
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
		num ^= pFDKKFPPAAA_.GetHashCode();
		num ^= cCOAKLKBPMF_.GetHashCode();
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
		pFDKKFPPAAA_.WriteTo(ref output, _repeated_pFDKKFPPAAA_codec);
		cCOAKLKBPMF_.WriteTo(ref output, _repeated_cCOAKLKBPMF_codec);
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
		num += pFDKKFPPAAA_.CalculateSize(_repeated_pFDKKFPPAAA_codec);
		num += cCOAKLKBPMF_.CalculateSize(_repeated_cCOAKLKBPMF_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KKNHIMGNMPG other)
	{
		if (other != null)
		{
			pFDKKFPPAAA_.Add(other.pFDKKFPPAAA_);
			cCOAKLKBPMF_.Add(other.cCOAKLKBPMF_);
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
				pFDKKFPPAAA_.AddEntriesFrom(ref input, _repeated_pFDKKFPPAAA_codec);
				break;
			case 16u:
			case 18u:
				cCOAKLKBPMF_.AddEntriesFrom(ref input, _repeated_cCOAKLKBPMF_codec);
				break;
			}
		}
	}
}
