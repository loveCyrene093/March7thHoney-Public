using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GPONAKNHLJG : IMessage<GPONAKNHLJG>, IMessage, IEquatable<GPONAKNHLJG>, IDeepCloneable<GPONAKNHLJG>, IBufferMessage
{
	private static readonly MessageParser<GPONAKNHLJG> _parser = new MessageParser<GPONAKNHLJG>(() => new GPONAKNHLJG());

	private UnknownFieldSet _unknownFields;

	public const int BHDDOFBIBACFieldNumber = 4;

	private static readonly FieldCodec<KACOOFIKHOG> _repeated_bHDDOFBIBAC_codec = FieldCodec.ForMessage(34u, KACOOFIKHOG.Parser);

	private readonly RepeatedField<KACOOFIKHOG> bHDDOFBIBAC_ = new RepeatedField<KACOOFIKHOG>();

	public const int UniqueIdFieldNumber = 10;

	private uint uniqueId_;

	public const int INOLOMFAHIEFieldNumber = 12;

	private uint iNOLOMFAHIE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GPONAKNHLJG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GPONAKNHLJGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<KACOOFIKHOG> BHDDOFBIBAC => bHDDOFBIBAC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint INOLOMFAHIE
	{
		get
		{
			return iNOLOMFAHIE_;
		}
		set
		{
			iNOLOMFAHIE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPONAKNHLJG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPONAKNHLJG(GPONAKNHLJG other)
		: this()
	{
		bHDDOFBIBAC_ = other.bHDDOFBIBAC_.Clone();
		uniqueId_ = other.uniqueId_;
		iNOLOMFAHIE_ = other.iNOLOMFAHIE_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GPONAKNHLJG Clone()
	{
		return new GPONAKNHLJG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GPONAKNHLJG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GPONAKNHLJG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bHDDOFBIBAC_.Equals(other.bHDDOFBIBAC_))
		{
			return false;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (INOLOMFAHIE != other.INOLOMFAHIE)
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
		num ^= bHDDOFBIBAC_.GetHashCode();
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (INOLOMFAHIE != 0)
		{
			num ^= INOLOMFAHIE.GetHashCode();
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
		bHDDOFBIBAC_.WriteTo(ref output, _repeated_bHDDOFBIBAC_codec);
		if (UniqueId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(UniqueId);
		}
		if (INOLOMFAHIE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(INOLOMFAHIE);
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
		num += bHDDOFBIBAC_.CalculateSize(_repeated_bHDDOFBIBAC_codec);
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (INOLOMFAHIE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(INOLOMFAHIE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GPONAKNHLJG other)
	{
		if (other != null)
		{
			bHDDOFBIBAC_.Add(other.bHDDOFBIBAC_);
			if (other.UniqueId != 0)
			{
				UniqueId = other.UniqueId;
			}
			if (other.INOLOMFAHIE != 0)
			{
				INOLOMFAHIE = other.INOLOMFAHIE;
			}
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
			case 34u:
				bHDDOFBIBAC_.AddEntriesFrom(ref input, _repeated_bHDDOFBIBAC_codec);
				break;
			case 80u:
				UniqueId = input.ReadUInt32();
				break;
			case 96u:
				INOLOMFAHIE = input.ReadUInt32();
				break;
			}
		}
	}
}
