using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LBCNAOFKCIL : IMessage<LBCNAOFKCIL>, IMessage, IEquatable<LBCNAOFKCIL>, IDeepCloneable<LBCNAOFKCIL>, IBufferMessage
{
	private static readonly MessageParser<LBCNAOFKCIL> _parser = new MessageParser<LBCNAOFKCIL>(() => new LBCNAOFKCIL());

	private UnknownFieldSet _unknownFields;

	public const int GNDEPOKFHPEFieldNumber = 11;

	private uint gNDEPOKFHPE_;

	public const int OMNFDNBEPLAFieldNumber = 13;

	private uint oMNFDNBEPLA_;

	public const int HJMGGLANHMLFieldNumber = 15;

	private uint hJMGGLANHML_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LBCNAOFKCIL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LBCNAOFKCILReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GNDEPOKFHPE
	{
		get
		{
			return gNDEPOKFHPE_;
		}
		set
		{
			gNDEPOKFHPE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OMNFDNBEPLA
	{
		get
		{
			return oMNFDNBEPLA_;
		}
		set
		{
			oMNFDNBEPLA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HJMGGLANHML
	{
		get
		{
			return hJMGGLANHML_;
		}
		set
		{
			hJMGGLANHML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBCNAOFKCIL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBCNAOFKCIL(LBCNAOFKCIL other)
		: this()
	{
		gNDEPOKFHPE_ = other.gNDEPOKFHPE_;
		oMNFDNBEPLA_ = other.oMNFDNBEPLA_;
		hJMGGLANHML_ = other.hJMGGLANHML_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LBCNAOFKCIL Clone()
	{
		return new LBCNAOFKCIL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LBCNAOFKCIL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LBCNAOFKCIL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GNDEPOKFHPE != other.GNDEPOKFHPE)
		{
			return false;
		}
		if (OMNFDNBEPLA != other.OMNFDNBEPLA)
		{
			return false;
		}
		if (HJMGGLANHML != other.HJMGGLANHML)
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
		if (GNDEPOKFHPE != 0)
		{
			num ^= GNDEPOKFHPE.GetHashCode();
		}
		if (OMNFDNBEPLA != 0)
		{
			num ^= OMNFDNBEPLA.GetHashCode();
		}
		if (HJMGGLANHML != 0)
		{
			num ^= HJMGGLANHML.GetHashCode();
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
		if (GNDEPOKFHPE != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GNDEPOKFHPE);
		}
		if (OMNFDNBEPLA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(OMNFDNBEPLA);
		}
		if (HJMGGLANHML != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HJMGGLANHML);
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
		if (GNDEPOKFHPE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GNDEPOKFHPE);
		}
		if (OMNFDNBEPLA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OMNFDNBEPLA);
		}
		if (HJMGGLANHML != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HJMGGLANHML);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LBCNAOFKCIL other)
	{
		if (other != null)
		{
			if (other.GNDEPOKFHPE != 0)
			{
				GNDEPOKFHPE = other.GNDEPOKFHPE;
			}
			if (other.OMNFDNBEPLA != 0)
			{
				OMNFDNBEPLA = other.OMNFDNBEPLA;
			}
			if (other.HJMGGLANHML != 0)
			{
				HJMGGLANHML = other.HJMGGLANHML;
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
			case 88u:
				GNDEPOKFHPE = input.ReadUInt32();
				break;
			case 104u:
				OMNFDNBEPLA = input.ReadUInt32();
				break;
			case 120u:
				HJMGGLANHML = input.ReadUInt32();
				break;
			}
		}
	}
}
