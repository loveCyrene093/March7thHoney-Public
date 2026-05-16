using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MLGALLEAEIC : IMessage<MLGALLEAEIC>, IMessage, IEquatable<MLGALLEAEIC>, IDeepCloneable<MLGALLEAEIC>, IBufferMessage
{
	private static readonly MessageParser<MLGALLEAEIC> _parser = new MessageParser<MLGALLEAEIC>(() => new MLGALLEAEIC());

	private UnknownFieldSet _unknownFields;

	public const int IHMKJGKOPKCFieldNumber = 2;

	private bool iHMKJGKOPKC_;

	public const int IJIMFPEKPOKFieldNumber = 7;

	private uint iJIMFPEKPOK_;

	public const int OAGMAELMDAEFieldNumber = 8;

	private KBNIJFEMBPJ oAGMAELMDAE_;

	public const int FHKEMCLFBONFieldNumber = 9;

	private GDKPBDAAKBH fHKEMCLFBON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MLGALLEAEIC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MLGALLEAEICReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IHMKJGKOPKC
	{
		get
		{
			return iHMKJGKOPKC_;
		}
		set
		{
			iHMKJGKOPKC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IJIMFPEKPOK
	{
		get
		{
			return iJIMFPEKPOK_;
		}
		set
		{
			iJIMFPEKPOK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KBNIJFEMBPJ OAGMAELMDAE
	{
		get
		{
			return oAGMAELMDAE_;
		}
		set
		{
			oAGMAELMDAE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDKPBDAAKBH FHKEMCLFBON
	{
		get
		{
			return fHKEMCLFBON_;
		}
		set
		{
			fHKEMCLFBON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLGALLEAEIC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLGALLEAEIC(MLGALLEAEIC other)
		: this()
	{
		iHMKJGKOPKC_ = other.iHMKJGKOPKC_;
		iJIMFPEKPOK_ = other.iJIMFPEKPOK_;
		oAGMAELMDAE_ = ((other.oAGMAELMDAE_ != null) ? other.oAGMAELMDAE_.Clone() : null);
		fHKEMCLFBON_ = ((other.fHKEMCLFBON_ != null) ? other.fHKEMCLFBON_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MLGALLEAEIC Clone()
	{
		return new MLGALLEAEIC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MLGALLEAEIC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MLGALLEAEIC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IHMKJGKOPKC != other.IHMKJGKOPKC)
		{
			return false;
		}
		if (IJIMFPEKPOK != other.IJIMFPEKPOK)
		{
			return false;
		}
		if (!object.Equals(OAGMAELMDAE, other.OAGMAELMDAE))
		{
			return false;
		}
		if (!object.Equals(FHKEMCLFBON, other.FHKEMCLFBON))
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
		if (IHMKJGKOPKC)
		{
			num ^= IHMKJGKOPKC.GetHashCode();
		}
		if (IJIMFPEKPOK != 0)
		{
			num ^= IJIMFPEKPOK.GetHashCode();
		}
		if (oAGMAELMDAE_ != null)
		{
			num ^= OAGMAELMDAE.GetHashCode();
		}
		if (fHKEMCLFBON_ != null)
		{
			num ^= FHKEMCLFBON.GetHashCode();
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
		if (IHMKJGKOPKC)
		{
			output.WriteRawTag(16);
			output.WriteBool(IHMKJGKOPKC);
		}
		if (IJIMFPEKPOK != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IJIMFPEKPOK);
		}
		if (oAGMAELMDAE_ != null)
		{
			output.WriteRawTag(66);
			output.WriteMessage(OAGMAELMDAE);
		}
		if (fHKEMCLFBON_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(FHKEMCLFBON);
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
		if (IHMKJGKOPKC)
		{
			num += 2;
		}
		if (IJIMFPEKPOK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IJIMFPEKPOK);
		}
		if (oAGMAELMDAE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OAGMAELMDAE);
		}
		if (fHKEMCLFBON_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FHKEMCLFBON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MLGALLEAEIC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.IHMKJGKOPKC)
		{
			IHMKJGKOPKC = other.IHMKJGKOPKC;
		}
		if (other.IJIMFPEKPOK != 0)
		{
			IJIMFPEKPOK = other.IJIMFPEKPOK;
		}
		if (other.oAGMAELMDAE_ != null)
		{
			if (oAGMAELMDAE_ == null)
			{
				OAGMAELMDAE = new KBNIJFEMBPJ();
			}
			OAGMAELMDAE.MergeFrom(other.OAGMAELMDAE);
		}
		if (other.fHKEMCLFBON_ != null)
		{
			if (fHKEMCLFBON_ == null)
			{
				FHKEMCLFBON = new GDKPBDAAKBH();
			}
			FHKEMCLFBON.MergeFrom(other.FHKEMCLFBON);
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
			case 16u:
				IHMKJGKOPKC = input.ReadBool();
				break;
			case 56u:
				IJIMFPEKPOK = input.ReadUInt32();
				break;
			case 66u:
				if (oAGMAELMDAE_ == null)
				{
					OAGMAELMDAE = new KBNIJFEMBPJ();
				}
				input.ReadMessage(OAGMAELMDAE);
				break;
			case 74u:
				if (fHKEMCLFBON_ == null)
				{
					FHKEMCLFBON = new GDKPBDAAKBH();
				}
				input.ReadMessage(FHKEMCLFBON);
				break;
			}
		}
	}
}
