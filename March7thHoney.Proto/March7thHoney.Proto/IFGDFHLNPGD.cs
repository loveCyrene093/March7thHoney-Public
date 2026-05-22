using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFGDFHLNPGD : IMessage<IFGDFHLNPGD>, IMessage, IEquatable<IFGDFHLNPGD>, IDeepCloneable<IFGDFHLNPGD>, IBufferMessage
{
	public enum JIPBEABGOAKOneofCase
	{
		None = 0,
		MNAIGBCOJDK = 2,
		EDDOAIJIOCC = 3,
		MCKLNGPCJIJ = 9,
		KKLONJPKLEP = 12,
		LJJALKIJONC = 13,
		DDPJEAIOILD = 14
	}

	private static readonly MessageParser<IFGDFHLNPGD> _parser = new MessageParser<IFGDFHLNPGD>(() => new IFGDFHLNPGD());

	private UnknownFieldSet _unknownFields;

	public const int MNAIGBCOJDKFieldNumber = 2;

	public const int EDDOAIJIOCCFieldNumber = 3;

	public const int MCKLNGPCJIJFieldNumber = 9;

	public const int KKLONJPKLEPFieldNumber = 12;

	public const int LJJALKIJONCFieldNumber = 13;

	public const int DDPJEAIOILDFieldNumber = 14;

	private object jIPBEABGOAK_;

	private JIPBEABGOAKOneofCase jIPBEABGOAKCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFGDFHLNPGD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFGDFHLNPGDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMNIILNPOBO MNAIGBCOJDK
	{
		get
		{
			if (jIPBEABGOAKCase_ != JIPBEABGOAKOneofCase.MNAIGBCOJDK)
			{
				return null;
			}
			return (PMNIILNPOBO)jIPBEABGOAK_;
		}
		set
		{
			jIPBEABGOAK_ = value;
			jIPBEABGOAKCase_ = ((value != null) ? JIPBEABGOAKOneofCase.MNAIGBCOJDK : JIPBEABGOAKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FNBKPIHBDFG EDDOAIJIOCC
	{
		get
		{
			if (jIPBEABGOAKCase_ != JIPBEABGOAKOneofCase.EDDOAIJIOCC)
			{
				return null;
			}
			return (FNBKPIHBDFG)jIPBEABGOAK_;
		}
		set
		{
			jIPBEABGOAK_ = value;
			jIPBEABGOAKCase_ = ((value != null) ? JIPBEABGOAKOneofCase.EDDOAIJIOCC : JIPBEABGOAKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GDMFDLBPFNN MCKLNGPCJIJ
	{
		get
		{
			if (jIPBEABGOAKCase_ != JIPBEABGOAKOneofCase.MCKLNGPCJIJ)
			{
				return null;
			}
			return (GDMFDLBPFNN)jIPBEABGOAK_;
		}
		set
		{
			jIPBEABGOAK_ = value;
			jIPBEABGOAKCase_ = ((value != null) ? JIPBEABGOAKOneofCase.MCKLNGPCJIJ : JIPBEABGOAKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ABINPBKHLPC KKLONJPKLEP
	{
		get
		{
			if (jIPBEABGOAKCase_ != JIPBEABGOAKOneofCase.KKLONJPKLEP)
			{
				return null;
			}
			return (ABINPBKHLPC)jIPBEABGOAK_;
		}
		set
		{
			jIPBEABGOAK_ = value;
			jIPBEABGOAKCase_ = ((value != null) ? JIPBEABGOAKOneofCase.KKLONJPKLEP : JIPBEABGOAKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ODLKOFOPBIH LJJALKIJONC
	{
		get
		{
			if (jIPBEABGOAKCase_ != JIPBEABGOAKOneofCase.LJJALKIJONC)
			{
				return null;
			}
			return (ODLKOFOPBIH)jIPBEABGOAK_;
		}
		set
		{
			jIPBEABGOAK_ = value;
			jIPBEABGOAKCase_ = ((value != null) ? JIPBEABGOAKOneofCase.LJJALKIJONC : JIPBEABGOAKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PMBIHJLAIPL DDPJEAIOILD
	{
		get
		{
			if (jIPBEABGOAKCase_ != JIPBEABGOAKOneofCase.DDPJEAIOILD)
			{
				return null;
			}
			return (PMBIHJLAIPL)jIPBEABGOAK_;
		}
		set
		{
			jIPBEABGOAK_ = value;
			jIPBEABGOAKCase_ = ((value != null) ? JIPBEABGOAKOneofCase.DDPJEAIOILD : JIPBEABGOAKOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JIPBEABGOAKOneofCase JIPBEABGOAKCase => jIPBEABGOAKCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFGDFHLNPGD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFGDFHLNPGD(IFGDFHLNPGD other)
		: this()
	{
		switch (other.JIPBEABGOAKCase)
		{
		case JIPBEABGOAKOneofCase.MNAIGBCOJDK:
			MNAIGBCOJDK = other.MNAIGBCOJDK.Clone();
			break;
		case JIPBEABGOAKOneofCase.EDDOAIJIOCC:
			EDDOAIJIOCC = other.EDDOAIJIOCC.Clone();
			break;
		case JIPBEABGOAKOneofCase.MCKLNGPCJIJ:
			MCKLNGPCJIJ = other.MCKLNGPCJIJ.Clone();
			break;
		case JIPBEABGOAKOneofCase.KKLONJPKLEP:
			KKLONJPKLEP = other.KKLONJPKLEP.Clone();
			break;
		case JIPBEABGOAKOneofCase.LJJALKIJONC:
			LJJALKIJONC = other.LJJALKIJONC.Clone();
			break;
		case JIPBEABGOAKOneofCase.DDPJEAIOILD:
			DDPJEAIOILD = other.DDPJEAIOILD.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFGDFHLNPGD Clone()
	{
		return new IFGDFHLNPGD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearJIPBEABGOAK()
	{
		jIPBEABGOAKCase_ = JIPBEABGOAKOneofCase.None;
		jIPBEABGOAK_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFGDFHLNPGD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFGDFHLNPGD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MNAIGBCOJDK, other.MNAIGBCOJDK))
		{
			return false;
		}
		if (!object.Equals(EDDOAIJIOCC, other.EDDOAIJIOCC))
		{
			return false;
		}
		if (!object.Equals(MCKLNGPCJIJ, other.MCKLNGPCJIJ))
		{
			return false;
		}
		if (!object.Equals(KKLONJPKLEP, other.KKLONJPKLEP))
		{
			return false;
		}
		if (!object.Equals(LJJALKIJONC, other.LJJALKIJONC))
		{
			return false;
		}
		if (!object.Equals(DDPJEAIOILD, other.DDPJEAIOILD))
		{
			return false;
		}
		if (JIPBEABGOAKCase != other.JIPBEABGOAKCase)
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
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MNAIGBCOJDK)
		{
			num ^= MNAIGBCOJDK.GetHashCode();
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.EDDOAIJIOCC)
		{
			num ^= EDDOAIJIOCC.GetHashCode();
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MCKLNGPCJIJ)
		{
			num ^= MCKLNGPCJIJ.GetHashCode();
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.KKLONJPKLEP)
		{
			num ^= KKLONJPKLEP.GetHashCode();
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.LJJALKIJONC)
		{
			num ^= LJJALKIJONC.GetHashCode();
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.DDPJEAIOILD)
		{
			num ^= DDPJEAIOILD.GetHashCode();
		}
		num ^= (int)jIPBEABGOAKCase_;
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
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MNAIGBCOJDK)
		{
			output.WriteRawTag(18);
			output.WriteMessage(MNAIGBCOJDK);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.EDDOAIJIOCC)
		{
			output.WriteRawTag(26);
			output.WriteMessage(EDDOAIJIOCC);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MCKLNGPCJIJ)
		{
			output.WriteRawTag(74);
			output.WriteMessage(MCKLNGPCJIJ);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.KKLONJPKLEP)
		{
			output.WriteRawTag(98);
			output.WriteMessage(KKLONJPKLEP);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.LJJALKIJONC)
		{
			output.WriteRawTag(106);
			output.WriteMessage(LJJALKIJONC);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.DDPJEAIOILD)
		{
			output.WriteRawTag(114);
			output.WriteMessage(DDPJEAIOILD);
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
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MNAIGBCOJDK)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNAIGBCOJDK);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.EDDOAIJIOCC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EDDOAIJIOCC);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MCKLNGPCJIJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MCKLNGPCJIJ);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.KKLONJPKLEP)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(KKLONJPKLEP);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.LJJALKIJONC)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LJJALKIJONC);
		}
		if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.DDPJEAIOILD)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DDPJEAIOILD);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFGDFHLNPGD other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.JIPBEABGOAKCase)
		{
		case JIPBEABGOAKOneofCase.MNAIGBCOJDK:
			if (MNAIGBCOJDK == null)
			{
				MNAIGBCOJDK = new PMNIILNPOBO();
			}
			MNAIGBCOJDK.MergeFrom(other.MNAIGBCOJDK);
			break;
		case JIPBEABGOAKOneofCase.EDDOAIJIOCC:
			if (EDDOAIJIOCC == null)
			{
				EDDOAIJIOCC = new FNBKPIHBDFG();
			}
			EDDOAIJIOCC.MergeFrom(other.EDDOAIJIOCC);
			break;
		case JIPBEABGOAKOneofCase.MCKLNGPCJIJ:
			if (MCKLNGPCJIJ == null)
			{
				MCKLNGPCJIJ = new GDMFDLBPFNN();
			}
			MCKLNGPCJIJ.MergeFrom(other.MCKLNGPCJIJ);
			break;
		case JIPBEABGOAKOneofCase.KKLONJPKLEP:
			if (KKLONJPKLEP == null)
			{
				KKLONJPKLEP = new ABINPBKHLPC();
			}
			KKLONJPKLEP.MergeFrom(other.KKLONJPKLEP);
			break;
		case JIPBEABGOAKOneofCase.LJJALKIJONC:
			if (LJJALKIJONC == null)
			{
				LJJALKIJONC = new ODLKOFOPBIH();
			}
			LJJALKIJONC.MergeFrom(other.LJJALKIJONC);
			break;
		case JIPBEABGOAKOneofCase.DDPJEAIOILD:
			if (DDPJEAIOILD == null)
			{
				DDPJEAIOILD = new PMBIHJLAIPL();
			}
			DDPJEAIOILD.MergeFrom(other.DDPJEAIOILD);
			break;
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
			{
				PMNIILNPOBO pMNIILNPOBO = new PMNIILNPOBO();
				if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MNAIGBCOJDK)
				{
					pMNIILNPOBO.MergeFrom(MNAIGBCOJDK);
				}
				input.ReadMessage(pMNIILNPOBO);
				MNAIGBCOJDK = pMNIILNPOBO;
				break;
			}
			case 26u:
			{
				FNBKPIHBDFG fNBKPIHBDFG = new FNBKPIHBDFG();
				if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.EDDOAIJIOCC)
				{
					fNBKPIHBDFG.MergeFrom(EDDOAIJIOCC);
				}
				input.ReadMessage(fNBKPIHBDFG);
				EDDOAIJIOCC = fNBKPIHBDFG;
				break;
			}
			case 74u:
			{
				GDMFDLBPFNN gDMFDLBPFNN = new GDMFDLBPFNN();
				if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.MCKLNGPCJIJ)
				{
					gDMFDLBPFNN.MergeFrom(MCKLNGPCJIJ);
				}
				input.ReadMessage(gDMFDLBPFNN);
				MCKLNGPCJIJ = gDMFDLBPFNN;
				break;
			}
			case 98u:
			{
				ABINPBKHLPC aBINPBKHLPC = new ABINPBKHLPC();
				if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.KKLONJPKLEP)
				{
					aBINPBKHLPC.MergeFrom(KKLONJPKLEP);
				}
				input.ReadMessage(aBINPBKHLPC);
				KKLONJPKLEP = aBINPBKHLPC;
				break;
			}
			case 106u:
			{
				ODLKOFOPBIH oDLKOFOPBIH = new ODLKOFOPBIH();
				if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.LJJALKIJONC)
				{
					oDLKOFOPBIH.MergeFrom(LJJALKIJONC);
				}
				input.ReadMessage(oDLKOFOPBIH);
				LJJALKIJONC = oDLKOFOPBIH;
				break;
			}
			case 114u:
			{
				PMBIHJLAIPL pMBIHJLAIPL = new PMBIHJLAIPL();
				if (jIPBEABGOAKCase_ == JIPBEABGOAKOneofCase.DDPJEAIOILD)
				{
					pMBIHJLAIPL.MergeFrom(DDPJEAIOILD);
				}
				input.ReadMessage(pMBIHJLAIPL);
				DDPJEAIOILD = pMBIHJLAIPL;
				break;
			}
			}
		}
	}
}
