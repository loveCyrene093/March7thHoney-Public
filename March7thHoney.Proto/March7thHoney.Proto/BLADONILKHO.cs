using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BLADONILKHO : IMessage<BLADONILKHO>, IMessage, IEquatable<BLADONILKHO>, IDeepCloneable<BLADONILKHO>, IBufferMessage
{
	private static readonly MessageParser<BLADONILKHO> _parser = new MessageParser<BLADONILKHO>(() => new BLADONILKHO());

	private UnknownFieldSet _unknownFields;

	public const int KJDGGNNFGGPFieldNumber = 9;

	private static readonly FieldCodec<uint> _repeated_kJDGGNNFGGP_codec = FieldCodec.ForUInt32(74u);

	private readonly RepeatedField<uint> kJDGGNNFGGP_ = new RepeatedField<uint>();

	public const int BGPBLOFCPMGFieldNumber = 10;

	private uint bGPBLOFCPMG_;

	public const int IGFEAHIKKPEFieldNumber = 12;

	private uint iGFEAHIKKPE_;

	public const int NEMFNMIPNAOFieldNumber = 13;

	private bool nEMFNMIPNAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BLADONILKHO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BLADONILKHOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> KJDGGNNFGGP => kJDGGNNFGGP_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BGPBLOFCPMG
	{
		get
		{
			return bGPBLOFCPMG_;
		}
		set
		{
			bGPBLOFCPMG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IGFEAHIKKPE
	{
		get
		{
			return iGFEAHIKKPE_;
		}
		set
		{
			iGFEAHIKKPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NEMFNMIPNAO
	{
		get
		{
			return nEMFNMIPNAO_;
		}
		set
		{
			nEMFNMIPNAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLADONILKHO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLADONILKHO(BLADONILKHO other)
		: this()
	{
		kJDGGNNFGGP_ = other.kJDGGNNFGGP_.Clone();
		bGPBLOFCPMG_ = other.bGPBLOFCPMG_;
		iGFEAHIKKPE_ = other.iGFEAHIKKPE_;
		nEMFNMIPNAO_ = other.nEMFNMIPNAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BLADONILKHO Clone()
	{
		return new BLADONILKHO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BLADONILKHO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BLADONILKHO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!kJDGGNNFGGP_.Equals(other.kJDGGNNFGGP_))
		{
			return false;
		}
		if (BGPBLOFCPMG != other.BGPBLOFCPMG)
		{
			return false;
		}
		if (IGFEAHIKKPE != other.IGFEAHIKKPE)
		{
			return false;
		}
		if (NEMFNMIPNAO != other.NEMFNMIPNAO)
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
		num ^= kJDGGNNFGGP_.GetHashCode();
		if (BGPBLOFCPMG != 0)
		{
			num ^= BGPBLOFCPMG.GetHashCode();
		}
		if (IGFEAHIKKPE != 0)
		{
			num ^= IGFEAHIKKPE.GetHashCode();
		}
		if (NEMFNMIPNAO)
		{
			num ^= NEMFNMIPNAO.GetHashCode();
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
		kJDGGNNFGGP_.WriteTo(ref output, _repeated_kJDGGNNFGGP_codec);
		if (BGPBLOFCPMG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(BGPBLOFCPMG);
		}
		if (IGFEAHIKKPE != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(IGFEAHIKKPE);
		}
		if (NEMFNMIPNAO)
		{
			output.WriteRawTag(104);
			output.WriteBool(NEMFNMIPNAO);
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
		num += kJDGGNNFGGP_.CalculateSize(_repeated_kJDGGNNFGGP_codec);
		if (BGPBLOFCPMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGPBLOFCPMG);
		}
		if (IGFEAHIKKPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IGFEAHIKKPE);
		}
		if (NEMFNMIPNAO)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BLADONILKHO other)
	{
		if (other != null)
		{
			kJDGGNNFGGP_.Add(other.kJDGGNNFGGP_);
			if (other.BGPBLOFCPMG != 0)
			{
				BGPBLOFCPMG = other.BGPBLOFCPMG;
			}
			if (other.IGFEAHIKKPE != 0)
			{
				IGFEAHIKKPE = other.IGFEAHIKKPE;
			}
			if (other.NEMFNMIPNAO)
			{
				NEMFNMIPNAO = other.NEMFNMIPNAO;
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
			case 72u:
			case 74u:
				kJDGGNNFGGP_.AddEntriesFrom(ref input, _repeated_kJDGGNNFGGP_codec);
				break;
			case 80u:
				BGPBLOFCPMG = input.ReadUInt32();
				break;
			case 96u:
				IGFEAHIKKPE = input.ReadUInt32();
				break;
			case 104u:
				NEMFNMIPNAO = input.ReadBool();
				break;
			}
		}
	}
}
