using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FCFFJAPIIFL : IMessage<FCFFJAPIIFL>, IMessage, IEquatable<FCFFJAPIIFL>, IDeepCloneable<FCFFJAPIIFL>, IBufferMessage
{
	private static readonly MessageParser<FCFFJAPIIFL> _parser = new MessageParser<FCFFJAPIIFL>(() => new FCFFJAPIIFL());

	private UnknownFieldSet _unknownFields;

	public const int OMIAHNAENKMFieldNumber = 4;

	private uint oMIAHNAENKM_;

	public const int JKPADPHCOJJFieldNumber = 9;

	private static readonly FieldCodec<FGPEFEELOCO> _repeated_jKPADPHCOJJ_codec = FieldCodec.ForMessage(74u, FGPEFEELOCO.Parser);

	private readonly RepeatedField<FGPEFEELOCO> jKPADPHCOJJ_ = new RepeatedField<FGPEFEELOCO>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FCFFJAPIIFL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FCFFJAPIIFLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OMIAHNAENKM
	{
		get
		{
			return oMIAHNAENKM_;
		}
		set
		{
			oMIAHNAENKM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FGPEFEELOCO> JKPADPHCOJJ => jKPADPHCOJJ_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCFFJAPIIFL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCFFJAPIIFL(FCFFJAPIIFL other)
		: this()
	{
		oMIAHNAENKM_ = other.oMIAHNAENKM_;
		jKPADPHCOJJ_ = other.jKPADPHCOJJ_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FCFFJAPIIFL Clone()
	{
		return new FCFFJAPIIFL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FCFFJAPIIFL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FCFFJAPIIFL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (OMIAHNAENKM != other.OMIAHNAENKM)
		{
			return false;
		}
		if (!jKPADPHCOJJ_.Equals(other.jKPADPHCOJJ_))
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
		if (OMIAHNAENKM != 0)
		{
			num ^= OMIAHNAENKM.GetHashCode();
		}
		num ^= jKPADPHCOJJ_.GetHashCode();
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
		if (OMIAHNAENKM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(OMIAHNAENKM);
		}
		jKPADPHCOJJ_.WriteTo(ref output, _repeated_jKPADPHCOJJ_codec);
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
		if (OMIAHNAENKM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OMIAHNAENKM);
		}
		num += jKPADPHCOJJ_.CalculateSize(_repeated_jKPADPHCOJJ_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FCFFJAPIIFL other)
	{
		if (other != null)
		{
			if (other.OMIAHNAENKM != 0)
			{
				OMIAHNAENKM = other.OMIAHNAENKM;
			}
			jKPADPHCOJJ_.Add(other.jKPADPHCOJJ_);
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
			case 32u:
				OMIAHNAENKM = input.ReadUInt32();
				break;
			case 74u:
				jKPADPHCOJJ_.AddEntriesFrom(ref input, _repeated_jKPADPHCOJJ_codec);
				break;
			}
		}
	}
}
