using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PBMHMEADLEC : IMessage<PBMHMEADLEC>, IMessage, IEquatable<PBMHMEADLEC>, IDeepCloneable<PBMHMEADLEC>, IBufferMessage
{
	private static readonly MessageParser<PBMHMEADLEC> _parser = new MessageParser<PBMHMEADLEC>(() => new PBMHMEADLEC());

	private UnknownFieldSet _unknownFields;

	public const int IGCJNCKEODGFieldNumber = 2;

	private static readonly FieldCodec<IEDEMFKBHFL> _repeated_iGCJNCKEODG_codec = FieldCodec.ForMessage(18u, IEDEMFKBHFL.Parser);

	private readonly RepeatedField<IEDEMFKBHFL> iGCJNCKEODG_ = new RepeatedField<IEDEMFKBHFL>();

	public const int HOPLDJJMGLMFieldNumber = 9;

	private static readonly FieldCodec<ADIPAKCFMOF> _repeated_hOPLDJJMGLM_codec = FieldCodec.ForMessage(74u, ADIPAKCFMOF.Parser);

	private readonly RepeatedField<ADIPAKCFMOF> hOPLDJJMGLM_ = new RepeatedField<ADIPAKCFMOF>();

	public const int BKGBEDMGJJDFieldNumber = 14;

	private OILBFIKHNPK bKGBEDMGJJD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PBMHMEADLEC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PBMHMEADLECReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<IEDEMFKBHFL> IGCJNCKEODG => iGCJNCKEODG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ADIPAKCFMOF> HOPLDJJMGLM => hOPLDJJMGLM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OILBFIKHNPK BKGBEDMGJJD
	{
		get
		{
			return bKGBEDMGJJD_;
		}
		set
		{
			bKGBEDMGJJD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBMHMEADLEC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBMHMEADLEC(PBMHMEADLEC other)
		: this()
	{
		iGCJNCKEODG_ = other.iGCJNCKEODG_.Clone();
		hOPLDJJMGLM_ = other.hOPLDJJMGLM_.Clone();
		bKGBEDMGJJD_ = ((other.bKGBEDMGJJD_ != null) ? other.bKGBEDMGJJD_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBMHMEADLEC Clone()
	{
		return new PBMHMEADLEC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PBMHMEADLEC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PBMHMEADLEC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iGCJNCKEODG_.Equals(other.iGCJNCKEODG_))
		{
			return false;
		}
		if (!hOPLDJJMGLM_.Equals(other.hOPLDJJMGLM_))
		{
			return false;
		}
		if (!object.Equals(BKGBEDMGJJD, other.BKGBEDMGJJD))
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
		num ^= iGCJNCKEODG_.GetHashCode();
		num ^= hOPLDJJMGLM_.GetHashCode();
		if (bKGBEDMGJJD_ != null)
		{
			num ^= BKGBEDMGJJD.GetHashCode();
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
		iGCJNCKEODG_.WriteTo(ref output, _repeated_iGCJNCKEODG_codec);
		hOPLDJJMGLM_.WriteTo(ref output, _repeated_hOPLDJJMGLM_codec);
		if (bKGBEDMGJJD_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BKGBEDMGJJD);
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
		num += iGCJNCKEODG_.CalculateSize(_repeated_iGCJNCKEODG_codec);
		num += hOPLDJJMGLM_.CalculateSize(_repeated_hOPLDJJMGLM_codec);
		if (bKGBEDMGJJD_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BKGBEDMGJJD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PBMHMEADLEC other)
	{
		if (other == null)
		{
			return;
		}
		iGCJNCKEODG_.Add(other.iGCJNCKEODG_);
		hOPLDJJMGLM_.Add(other.hOPLDJJMGLM_);
		if (other.bKGBEDMGJJD_ != null)
		{
			if (bKGBEDMGJJD_ == null)
			{
				BKGBEDMGJJD = new OILBFIKHNPK();
			}
			BKGBEDMGJJD.MergeFrom(other.BKGBEDMGJJD);
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
			case 18u:
				iGCJNCKEODG_.AddEntriesFrom(ref input, _repeated_iGCJNCKEODG_codec);
				break;
			case 74u:
				hOPLDJJMGLM_.AddEntriesFrom(ref input, _repeated_hOPLDJJMGLM_codec);
				break;
			case 114u:
				if (bKGBEDMGJJD_ == null)
				{
					BKGBEDMGJJD = new OILBFIKHNPK();
				}
				input.ReadMessage(BKGBEDMGJJD);
				break;
			}
		}
	}
}
