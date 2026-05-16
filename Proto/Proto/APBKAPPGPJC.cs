using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class APBKAPPGPJC : IMessage<APBKAPPGPJC>, IMessage, IEquatable<APBKAPPGPJC>, IDeepCloneable<APBKAPPGPJC>, IBufferMessage
{
	private static readonly MessageParser<APBKAPPGPJC> _parser = new MessageParser<APBKAPPGPJC>(() => new APBKAPPGPJC());

	private UnknownFieldSet _unknownFields;

	public const int EAADBOCJNAEFieldNumber = 2;

	private uint eAADBOCJNAE_;

	public const int IGFEAHIKKPEFieldNumber = 4;

	private uint iGFEAHIKKPE_;

	public const int NEMFNMIPNAOFieldNumber = 7;

	private bool nEMFNMIPNAO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<APBKAPPGPJC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => APBKAPPGPJCReflection.Descriptor.MessageTypes[0];

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
	public APBKAPPGPJC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APBKAPPGPJC(APBKAPPGPJC other)
		: this()
	{
		eAADBOCJNAE_ = other.eAADBOCJNAE_;
		iGFEAHIKKPE_ = other.iGFEAHIKKPE_;
		nEMFNMIPNAO_ = other.nEMFNMIPNAO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public APBKAPPGPJC Clone()
	{
		return new APBKAPPGPJC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as APBKAPPGPJC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(APBKAPPGPJC other)
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
			output.WriteRawTag(16);
			output.WriteUInt32(EAADBOCJNAE);
		}
		if (IGFEAHIKKPE != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(IGFEAHIKKPE);
		}
		if (NEMFNMIPNAO)
		{
			output.WriteRawTag(56);
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
	public void MergeFrom(APBKAPPGPJC other)
	{
		if (other != null)
		{
			if (other.EAADBOCJNAE != 0)
			{
				EAADBOCJNAE = other.EAADBOCJNAE;
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
			case 16u:
				EAADBOCJNAE = input.ReadUInt32();
				break;
			case 32u:
				IGFEAHIKKPE = input.ReadUInt32();
				break;
			case 56u:
				NEMFNMIPNAO = input.ReadBool();
				break;
			}
		}
	}
}
