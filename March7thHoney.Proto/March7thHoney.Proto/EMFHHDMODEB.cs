using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EMFHHDMODEB : IMessage<EMFHHDMODEB>, IMessage, IEquatable<EMFHHDMODEB>, IDeepCloneable<EMFHHDMODEB>, IBufferMessage
{
	private static readonly MessageParser<EMFHHDMODEB> _parser = new MessageParser<EMFHHDMODEB>(() => new EMFHHDMODEB());

	private UnknownFieldSet _unknownFields;

	public const int EAADBOCJNAEFieldNumber = 1;

	private uint eAADBOCJNAE_;

	public const int BGPBLOFCPMGFieldNumber = 8;

	private uint bGPBLOFCPMG_;

	public const int KJDGGNNFGGPFieldNumber = 10;

	private static readonly FieldCodec<uint> _repeated_kJDGGNNFGGP_codec = FieldCodec.ForUInt32(82u);

	private readonly RepeatedField<uint> kJDGGNNFGGP_ = new RepeatedField<uint>();

	public const int IGFEAHIKKPEFieldNumber = 11;

	private uint iGFEAHIKKPE_;

	public const int NEMFNMIPNAOFieldNumber = 14;

	private bool nEMFNMIPNAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EMFHHDMODEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EMFHHDMODEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint EAADBOCJNAE
	{
		get
		{
			return eAADBOCJNAE_;
		}
		set
		{
			eAADBOCJNAE_ = value;
		}
	}

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
	public RepeatedField<uint> KJDGGNNFGGP => kJDGGNNFGGP_;

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
	public EMFHHDMODEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMFHHDMODEB(EMFHHDMODEB other)
		: this()
	{
		eAADBOCJNAE_ = other.eAADBOCJNAE_;
		bGPBLOFCPMG_ = other.bGPBLOFCPMG_;
		kJDGGNNFGGP_ = other.kJDGGNNFGGP_.Clone();
		iGFEAHIKKPE_ = other.iGFEAHIKKPE_;
		nEMFNMIPNAO_ = other.nEMFNMIPNAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EMFHHDMODEB Clone()
	{
		return new EMFHHDMODEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EMFHHDMODEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EMFHHDMODEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (EAADBOCJNAE != other.EAADBOCJNAE)
		{
			return false;
		}
		if (BGPBLOFCPMG != other.BGPBLOFCPMG)
		{
			return false;
		}
		if (!kJDGGNNFGGP_.Equals(other.kJDGGNNFGGP_))
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
		if (EAADBOCJNAE != 0)
		{
			num ^= EAADBOCJNAE.GetHashCode();
		}
		if (BGPBLOFCPMG != 0)
		{
			num ^= BGPBLOFCPMG.GetHashCode();
		}
		num ^= kJDGGNNFGGP_.GetHashCode();
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
		if (EAADBOCJNAE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(EAADBOCJNAE);
		}
		if (BGPBLOFCPMG != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(BGPBLOFCPMG);
		}
		kJDGGNNFGGP_.WriteTo(ref output, _repeated_kJDGGNNFGGP_codec);
		if (IGFEAHIKKPE != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(IGFEAHIKKPE);
		}
		if (NEMFNMIPNAO)
		{
			output.WriteRawTag(112);
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
		if (EAADBOCJNAE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(EAADBOCJNAE);
		}
		if (BGPBLOFCPMG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BGPBLOFCPMG);
		}
		num += kJDGGNNFGGP_.CalculateSize(_repeated_kJDGGNNFGGP_codec);
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
	public void MergeFrom(EMFHHDMODEB other)
	{
		if (other != null)
		{
			if (other.EAADBOCJNAE != 0)
			{
				EAADBOCJNAE = other.EAADBOCJNAE;
			}
			if (other.BGPBLOFCPMG != 0)
			{
				BGPBLOFCPMG = other.BGPBLOFCPMG;
			}
			kJDGGNNFGGP_.Add(other.kJDGGNNFGGP_);
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
			case 8u:
				EAADBOCJNAE = input.ReadUInt32();
				break;
			case 64u:
				BGPBLOFCPMG = input.ReadUInt32();
				break;
			case 80u:
			case 82u:
				kJDGGNNFGGP_.AddEntriesFrom(ref input, _repeated_kJDGGNNFGGP_codec);
				break;
			case 88u:
				IGFEAHIKKPE = input.ReadUInt32();
				break;
			case 112u:
				NEMFNMIPNAO = input.ReadBool();
				break;
			}
		}
	}
}
