using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ODONLHDAPKB : IMessage<ODONLHDAPKB>, IMessage, IEquatable<ODONLHDAPKB>, IDeepCloneable<ODONLHDAPKB>, IBufferMessage
{
	private static readonly MessageParser<ODONLHDAPKB> _parser = new MessageParser<ODONLHDAPKB>(() => new ODONLHDAPKB());

	private UnknownFieldSet _unknownFields;

	public const int IBBNLMBCLHFFieldNumber = 1;

	private uint iBBNLMBCLHF_;

	public const int CCJEPAAJOHOFieldNumber = 2;

	private uint cCJEPAAJOHO_;

	public const int AIJGKIOMFLPFieldNumber = 3;

	private uint aIJGKIOMFLP_;

	public const int DLDGHJEJDPFFieldNumber = 6;

	private uint dLDGHJEJDPF_;

	public const int CGGNLACJGCLFieldNumber = 8;

	private uint cGGNLACJGCL_;

	public const int EDBNODEOHDAFieldNumber = 9;

	private bool eDBNODEOHDA_;

	public const int NNAOHMMIBEBFieldNumber = 10;

	private uint nNAOHMMIBEB_;

	public const int BPBKPAKELGHFieldNumber = 11;

	private uint bPBKPAKELGH_;

	public const int AKDKLJLONBAFieldNumber = 13;

	private uint aKDKLJLONBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ODONLHDAPKB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ODONLHDAPKBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBBNLMBCLHF
	{
		get
		{
			return iBBNLMBCLHF_;
		}
		set
		{
			iBBNLMBCLHF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CCJEPAAJOHO
	{
		get
		{
			return cCJEPAAJOHO_;
		}
		set
		{
			cCJEPAAJOHO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AIJGKIOMFLP
	{
		get
		{
			return aIJGKIOMFLP_;
		}
		set
		{
			aIJGKIOMFLP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DLDGHJEJDPF
	{
		get
		{
			return dLDGHJEJDPF_;
		}
		set
		{
			dLDGHJEJDPF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CGGNLACJGCL
	{
		get
		{
			return cGGNLACJGCL_;
		}
		set
		{
			cGGNLACJGCL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool EDBNODEOHDA
	{
		get
		{
			return eDBNODEOHDA_;
		}
		set
		{
			eDBNODEOHDA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NNAOHMMIBEB
	{
		get
		{
			return nNAOHMMIBEB_;
		}
		set
		{
			nNAOHMMIBEB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BPBKPAKELGH
	{
		get
		{
			return bPBKPAKELGH_;
		}
		set
		{
			bPBKPAKELGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AKDKLJLONBA
	{
		get
		{
			return aKDKLJLONBA_;
		}
		set
		{
			aKDKLJLONBA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODONLHDAPKB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODONLHDAPKB(ODONLHDAPKB other)
		: this()
	{
		iBBNLMBCLHF_ = other.iBBNLMBCLHF_;
		cCJEPAAJOHO_ = other.cCJEPAAJOHO_;
		aIJGKIOMFLP_ = other.aIJGKIOMFLP_;
		dLDGHJEJDPF_ = other.dLDGHJEJDPF_;
		cGGNLACJGCL_ = other.cGGNLACJGCL_;
		eDBNODEOHDA_ = other.eDBNODEOHDA_;
		nNAOHMMIBEB_ = other.nNAOHMMIBEB_;
		bPBKPAKELGH_ = other.bPBKPAKELGH_;
		aKDKLJLONBA_ = other.aKDKLJLONBA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODONLHDAPKB Clone()
	{
		return new ODONLHDAPKB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ODONLHDAPKB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ODONLHDAPKB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IBBNLMBCLHF != other.IBBNLMBCLHF)
		{
			return false;
		}
		if (CCJEPAAJOHO != other.CCJEPAAJOHO)
		{
			return false;
		}
		if (AIJGKIOMFLP != other.AIJGKIOMFLP)
		{
			return false;
		}
		if (DLDGHJEJDPF != other.DLDGHJEJDPF)
		{
			return false;
		}
		if (CGGNLACJGCL != other.CGGNLACJGCL)
		{
			return false;
		}
		if (EDBNODEOHDA != other.EDBNODEOHDA)
		{
			return false;
		}
		if (NNAOHMMIBEB != other.NNAOHMMIBEB)
		{
			return false;
		}
		if (BPBKPAKELGH != other.BPBKPAKELGH)
		{
			return false;
		}
		if (AKDKLJLONBA != other.AKDKLJLONBA)
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
		if (IBBNLMBCLHF != 0)
		{
			num ^= IBBNLMBCLHF.GetHashCode();
		}
		if (CCJEPAAJOHO != 0)
		{
			num ^= CCJEPAAJOHO.GetHashCode();
		}
		if (AIJGKIOMFLP != 0)
		{
			num ^= AIJGKIOMFLP.GetHashCode();
		}
		if (DLDGHJEJDPF != 0)
		{
			num ^= DLDGHJEJDPF.GetHashCode();
		}
		if (CGGNLACJGCL != 0)
		{
			num ^= CGGNLACJGCL.GetHashCode();
		}
		if (EDBNODEOHDA)
		{
			num ^= EDBNODEOHDA.GetHashCode();
		}
		if (NNAOHMMIBEB != 0)
		{
			num ^= NNAOHMMIBEB.GetHashCode();
		}
		if (BPBKPAKELGH != 0)
		{
			num ^= BPBKPAKELGH.GetHashCode();
		}
		if (AKDKLJLONBA != 0)
		{
			num ^= AKDKLJLONBA.GetHashCode();
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
		if (IBBNLMBCLHF != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(IBBNLMBCLHF);
		}
		if (CCJEPAAJOHO != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(CCJEPAAJOHO);
		}
		if (AIJGKIOMFLP != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(AIJGKIOMFLP);
		}
		if (DLDGHJEJDPF != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(DLDGHJEJDPF);
		}
		if (CGGNLACJGCL != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(CGGNLACJGCL);
		}
		if (EDBNODEOHDA)
		{
			output.WriteRawTag(72);
			output.WriteBool(EDBNODEOHDA);
		}
		if (NNAOHMMIBEB != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(NNAOHMMIBEB);
		}
		if (BPBKPAKELGH != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(BPBKPAKELGH);
		}
		if (AKDKLJLONBA != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(AKDKLJLONBA);
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
		if (IBBNLMBCLHF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBBNLMBCLHF);
		}
		if (CCJEPAAJOHO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CCJEPAAJOHO);
		}
		if (AIJGKIOMFLP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AIJGKIOMFLP);
		}
		if (DLDGHJEJDPF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DLDGHJEJDPF);
		}
		if (CGGNLACJGCL != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CGGNLACJGCL);
		}
		if (EDBNODEOHDA)
		{
			num += 2;
		}
		if (NNAOHMMIBEB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NNAOHMMIBEB);
		}
		if (BPBKPAKELGH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BPBKPAKELGH);
		}
		if (AKDKLJLONBA != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AKDKLJLONBA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ODONLHDAPKB other)
	{
		if (other != null)
		{
			if (other.IBBNLMBCLHF != 0)
			{
				IBBNLMBCLHF = other.IBBNLMBCLHF;
			}
			if (other.CCJEPAAJOHO != 0)
			{
				CCJEPAAJOHO = other.CCJEPAAJOHO;
			}
			if (other.AIJGKIOMFLP != 0)
			{
				AIJGKIOMFLP = other.AIJGKIOMFLP;
			}
			if (other.DLDGHJEJDPF != 0)
			{
				DLDGHJEJDPF = other.DLDGHJEJDPF;
			}
			if (other.CGGNLACJGCL != 0)
			{
				CGGNLACJGCL = other.CGGNLACJGCL;
			}
			if (other.EDBNODEOHDA)
			{
				EDBNODEOHDA = other.EDBNODEOHDA;
			}
			if (other.NNAOHMMIBEB != 0)
			{
				NNAOHMMIBEB = other.NNAOHMMIBEB;
			}
			if (other.BPBKPAKELGH != 0)
			{
				BPBKPAKELGH = other.BPBKPAKELGH;
			}
			if (other.AKDKLJLONBA != 0)
			{
				AKDKLJLONBA = other.AKDKLJLONBA;
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
				IBBNLMBCLHF = input.ReadUInt32();
				break;
			case 16u:
				CCJEPAAJOHO = input.ReadUInt32();
				break;
			case 24u:
				AIJGKIOMFLP = input.ReadUInt32();
				break;
			case 48u:
				DLDGHJEJDPF = input.ReadUInt32();
				break;
			case 64u:
				CGGNLACJGCL = input.ReadUInt32();
				break;
			case 72u:
				EDBNODEOHDA = input.ReadBool();
				break;
			case 80u:
				NNAOHMMIBEB = input.ReadUInt32();
				break;
			case 88u:
				BPBKPAKELGH = input.ReadUInt32();
				break;
			case 104u:
				AKDKLJLONBA = input.ReadUInt32();
				break;
			}
		}
	}
}
