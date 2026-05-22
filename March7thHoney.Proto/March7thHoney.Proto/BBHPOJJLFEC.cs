using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BBHPOJJLFEC : IMessage<BBHPOJJLFEC>, IMessage, IEquatable<BBHPOJJLFEC>, IDeepCloneable<BBHPOJJLFEC>, IBufferMessage
{
	private static readonly MessageParser<BBHPOJJLFEC> _parser = new MessageParser<BBHPOJJLFEC>(() => new BBHPOJJLFEC());

	private UnknownFieldSet _unknownFields;

	public const int AKAGAAMOJCFFieldNumber = 4;

	private uint aKAGAAMOJCF_;

	public const int BHLABMIODGOFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_bHLABMIODGO_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> bHLABMIODGO_ = new RepeatedField<uint>();

	public const int JGAIPHCIJHBFieldNumber = 12;

	private static readonly FieldCodec<uint> _repeated_jGAIPHCIJHB_codec = FieldCodec.ForUInt32(98u);

	private readonly RepeatedField<uint> jGAIPHCIJHB_ = new RepeatedField<uint>();

	public const int IEAILOCMKNNFieldNumber = 13;

	private uint iEAILOCMKNN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BBHPOJJLFEC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BBHPOJJLFECReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKAGAAMOJCF
	{
		get
		{
			return aKAGAAMOJCF_;
		}
		set
		{
			aKAGAAMOJCF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> BHLABMIODGO => bHLABMIODGO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> JGAIPHCIJHB => jGAIPHCIJHB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IEAILOCMKNN
	{
		get
		{
			return iEAILOCMKNN_;
		}
		set
		{
			iEAILOCMKNN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBHPOJJLFEC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBHPOJJLFEC(BBHPOJJLFEC other)
		: this()
	{
		aKAGAAMOJCF_ = other.aKAGAAMOJCF_;
		bHLABMIODGO_ = other.bHLABMIODGO_.Clone();
		jGAIPHCIJHB_ = other.jGAIPHCIJHB_.Clone();
		iEAILOCMKNN_ = other.iEAILOCMKNN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BBHPOJJLFEC Clone()
	{
		return new BBHPOJJLFEC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BBHPOJJLFEC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BBHPOJJLFEC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AKAGAAMOJCF != other.AKAGAAMOJCF)
		{
			return false;
		}
		if (!bHLABMIODGO_.Equals(other.bHLABMIODGO_))
		{
			return false;
		}
		if (!jGAIPHCIJHB_.Equals(other.jGAIPHCIJHB_))
		{
			return false;
		}
		if (IEAILOCMKNN != other.IEAILOCMKNN)
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
		if (AKAGAAMOJCF != 0)
		{
			num ^= AKAGAAMOJCF.GetHashCode();
		}
		num ^= bHLABMIODGO_.GetHashCode();
		num ^= jGAIPHCIJHB_.GetHashCode();
		if (IEAILOCMKNN != 0)
		{
			num ^= IEAILOCMKNN.GetHashCode();
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
		if (AKAGAAMOJCF != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(AKAGAAMOJCF);
		}
		bHLABMIODGO_.WriteTo(ref output, _repeated_bHLABMIODGO_codec);
		jGAIPHCIJHB_.WriteTo(ref output, _repeated_jGAIPHCIJHB_codec);
		if (IEAILOCMKNN != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(IEAILOCMKNN);
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
		if (AKAGAAMOJCF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AKAGAAMOJCF);
		}
		num += bHLABMIODGO_.CalculateSize(_repeated_bHLABMIODGO_codec);
		num += jGAIPHCIJHB_.CalculateSize(_repeated_jGAIPHCIJHB_codec);
		if (IEAILOCMKNN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IEAILOCMKNN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BBHPOJJLFEC other)
	{
		if (other != null)
		{
			if (other.AKAGAAMOJCF != 0)
			{
				AKAGAAMOJCF = other.AKAGAAMOJCF;
			}
			bHLABMIODGO_.Add(other.bHLABMIODGO_);
			jGAIPHCIJHB_.Add(other.jGAIPHCIJHB_);
			if (other.IEAILOCMKNN != 0)
			{
				IEAILOCMKNN = other.IEAILOCMKNN;
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
			case 32u:
				AKAGAAMOJCF = input.ReadUInt32();
				break;
			case 72u:
			case 74u:
				bHLABMIODGO_.AddEntriesFrom(ref input, _repeated_bHLABMIODGO_codec);
				break;
			case 96u:
			case 98u:
				jGAIPHCIJHB_.AddEntriesFrom(ref input, _repeated_jGAIPHCIJHB_codec);
				break;
			case 104u:
				IEAILOCMKNN = input.ReadUInt32();
				break;
			}
		}
	}
}
