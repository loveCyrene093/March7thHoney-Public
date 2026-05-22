using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JAFMFGJLGGA : IMessage<JAFMFGJLGGA>, IMessage, IEquatable<JAFMFGJLGGA>, IDeepCloneable<JAFMFGJLGGA>, IBufferMessage
{
	public enum BJHPPIKHFMFOneofCase
	{
		None,
		DENHCJPAMAN,
		AEDBEGKAJMM,
		FFLLCPHLNIO,
		LEFOIGFGJGJ,
		INFGAKANLPN
	}

	private static readonly MessageParser<JAFMFGJLGGA> _parser = new MessageParser<JAFMFGJLGGA>(() => new JAFMFGJLGGA());

	private UnknownFieldSet _unknownFields;

	public const int DENHCJPAMANFieldNumber = 1;

	public const int AEDBEGKAJMMFieldNumber = 2;

	public const int FFLLCPHLNIOFieldNumber = 3;

	public const int LEFOIGFGJGJFieldNumber = 4;

	public const int INFGAKANLPNFieldNumber = 5;

	private object bJHPPIKHFMF_;

	private BJHPPIKHFMFOneofCase bJHPPIKHFMFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JAFMFGJLGGA> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JAFMFGJLGGAReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LPFDDGKBAAM DENHCJPAMAN
	{
		get
		{
			if (bJHPPIKHFMFCase_ != BJHPPIKHFMFOneofCase.DENHCJPAMAN)
			{
				return null;
			}
			return (LPFDDGKBAAM)bJHPPIKHFMF_;
		}
		set
		{
			bJHPPIKHFMF_ = value;
			bJHPPIKHFMFCase_ = ((value != null) ? BJHPPIKHFMFOneofCase.DENHCJPAMAN : BJHPPIKHFMFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFMPGKCILMN AEDBEGKAJMM
	{
		get
		{
			if (bJHPPIKHFMFCase_ != BJHPPIKHFMFOneofCase.AEDBEGKAJMM)
			{
				return null;
			}
			return (LFMPGKCILMN)bJHPPIKHFMF_;
		}
		set
		{
			bJHPPIKHFMF_ = value;
			bJHPPIKHFMFCase_ = ((value != null) ? BJHPPIKHFMFOneofCase.AEDBEGKAJMM : BJHPPIKHFMFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFGGENLKMEB FFLLCPHLNIO
	{
		get
		{
			if (bJHPPIKHFMFCase_ != BJHPPIKHFMFOneofCase.FFLLCPHLNIO)
			{
				return null;
			}
			return (KFGGENLKMEB)bJHPPIKHFMF_;
		}
		set
		{
			bJHPPIKHFMF_ = value;
			bJHPPIKHFMFCase_ = ((value != null) ? BJHPPIKHFMFOneofCase.FFLLCPHLNIO : BJHPPIKHFMFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LLANPOBDJIM LEFOIGFGJGJ
	{
		get
		{
			if (bJHPPIKHFMFCase_ != BJHPPIKHFMFOneofCase.LEFOIGFGJGJ)
			{
				return null;
			}
			return (LLANPOBDJIM)bJHPPIKHFMF_;
		}
		set
		{
			bJHPPIKHFMF_ = value;
			bJHPPIKHFMFCase_ = ((value != null) ? BJHPPIKHFMFOneofCase.LEFOIGFGJGJ : BJHPPIKHFMFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PFBKJICJGBI INFGAKANLPN
	{
		get
		{
			if (bJHPPIKHFMFCase_ != BJHPPIKHFMFOneofCase.INFGAKANLPN)
			{
				return null;
			}
			return (PFBKJICJGBI)bJHPPIKHFMF_;
		}
		set
		{
			bJHPPIKHFMF_ = value;
			bJHPPIKHFMFCase_ = ((value != null) ? BJHPPIKHFMFOneofCase.INFGAKANLPN : BJHPPIKHFMFOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BJHPPIKHFMFOneofCase BJHPPIKHFMFCase => bJHPPIKHFMFCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAFMFGJLGGA()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAFMFGJLGGA(JAFMFGJLGGA other)
		: this()
	{
		switch (other.BJHPPIKHFMFCase)
		{
		case BJHPPIKHFMFOneofCase.DENHCJPAMAN:
			DENHCJPAMAN = other.DENHCJPAMAN.Clone();
			break;
		case BJHPPIKHFMFOneofCase.AEDBEGKAJMM:
			AEDBEGKAJMM = other.AEDBEGKAJMM.Clone();
			break;
		case BJHPPIKHFMFOneofCase.FFLLCPHLNIO:
			FFLLCPHLNIO = other.FFLLCPHLNIO.Clone();
			break;
		case BJHPPIKHFMFOneofCase.LEFOIGFGJGJ:
			LEFOIGFGJGJ = other.LEFOIGFGJGJ.Clone();
			break;
		case BJHPPIKHFMFOneofCase.INFGAKANLPN:
			INFGAKANLPN = other.INFGAKANLPN.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JAFMFGJLGGA Clone()
	{
		return new JAFMFGJLGGA(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBJHPPIKHFMF()
	{
		bJHPPIKHFMFCase_ = BJHPPIKHFMFOneofCase.None;
		bJHPPIKHFMF_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JAFMFGJLGGA);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JAFMFGJLGGA other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DENHCJPAMAN, other.DENHCJPAMAN))
		{
			return false;
		}
		if (!object.Equals(AEDBEGKAJMM, other.AEDBEGKAJMM))
		{
			return false;
		}
		if (!object.Equals(FFLLCPHLNIO, other.FFLLCPHLNIO))
		{
			return false;
		}
		if (!object.Equals(LEFOIGFGJGJ, other.LEFOIGFGJGJ))
		{
			return false;
		}
		if (!object.Equals(INFGAKANLPN, other.INFGAKANLPN))
		{
			return false;
		}
		if (BJHPPIKHFMFCase != other.BJHPPIKHFMFCase)
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
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.DENHCJPAMAN)
		{
			num ^= DENHCJPAMAN.GetHashCode();
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.AEDBEGKAJMM)
		{
			num ^= AEDBEGKAJMM.GetHashCode();
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.FFLLCPHLNIO)
		{
			num ^= FFLLCPHLNIO.GetHashCode();
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.LEFOIGFGJGJ)
		{
			num ^= LEFOIGFGJGJ.GetHashCode();
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.INFGAKANLPN)
		{
			num ^= INFGAKANLPN.GetHashCode();
		}
		num ^= (int)bJHPPIKHFMFCase_;
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
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.DENHCJPAMAN)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DENHCJPAMAN);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.AEDBEGKAJMM)
		{
			output.WriteRawTag(18);
			output.WriteMessage(AEDBEGKAJMM);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.FFLLCPHLNIO)
		{
			output.WriteRawTag(26);
			output.WriteMessage(FFLLCPHLNIO);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.LEFOIGFGJGJ)
		{
			output.WriteRawTag(34);
			output.WriteMessage(LEFOIGFGJGJ);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.INFGAKANLPN)
		{
			output.WriteRawTag(42);
			output.WriteMessage(INFGAKANLPN);
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
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.DENHCJPAMAN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DENHCJPAMAN);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.AEDBEGKAJMM)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(AEDBEGKAJMM);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.FFLLCPHLNIO)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(FFLLCPHLNIO);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.LEFOIGFGJGJ)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(LEFOIGFGJGJ);
		}
		if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.INFGAKANLPN)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(INFGAKANLPN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JAFMFGJLGGA other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BJHPPIKHFMFCase)
		{
		case BJHPPIKHFMFOneofCase.DENHCJPAMAN:
			if (DENHCJPAMAN == null)
			{
				DENHCJPAMAN = new LPFDDGKBAAM();
			}
			DENHCJPAMAN.MergeFrom(other.DENHCJPAMAN);
			break;
		case BJHPPIKHFMFOneofCase.AEDBEGKAJMM:
			if (AEDBEGKAJMM == null)
			{
				AEDBEGKAJMM = new LFMPGKCILMN();
			}
			AEDBEGKAJMM.MergeFrom(other.AEDBEGKAJMM);
			break;
		case BJHPPIKHFMFOneofCase.FFLLCPHLNIO:
			if (FFLLCPHLNIO == null)
			{
				FFLLCPHLNIO = new KFGGENLKMEB();
			}
			FFLLCPHLNIO.MergeFrom(other.FFLLCPHLNIO);
			break;
		case BJHPPIKHFMFOneofCase.LEFOIGFGJGJ:
			if (LEFOIGFGJGJ == null)
			{
				LEFOIGFGJGJ = new LLANPOBDJIM();
			}
			LEFOIGFGJGJ.MergeFrom(other.LEFOIGFGJGJ);
			break;
		case BJHPPIKHFMFOneofCase.INFGAKANLPN:
			if (INFGAKANLPN == null)
			{
				INFGAKANLPN = new PFBKJICJGBI();
			}
			INFGAKANLPN.MergeFrom(other.INFGAKANLPN);
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
			case 10u:
			{
				LPFDDGKBAAM lPFDDGKBAAM = new LPFDDGKBAAM();
				if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.DENHCJPAMAN)
				{
					lPFDDGKBAAM.MergeFrom(DENHCJPAMAN);
				}
				input.ReadMessage(lPFDDGKBAAM);
				DENHCJPAMAN = lPFDDGKBAAM;
				break;
			}
			case 18u:
			{
				LFMPGKCILMN lFMPGKCILMN = new LFMPGKCILMN();
				if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.AEDBEGKAJMM)
				{
					lFMPGKCILMN.MergeFrom(AEDBEGKAJMM);
				}
				input.ReadMessage(lFMPGKCILMN);
				AEDBEGKAJMM = lFMPGKCILMN;
				break;
			}
			case 26u:
			{
				KFGGENLKMEB kFGGENLKMEB = new KFGGENLKMEB();
				if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.FFLLCPHLNIO)
				{
					kFGGENLKMEB.MergeFrom(FFLLCPHLNIO);
				}
				input.ReadMessage(kFGGENLKMEB);
				FFLLCPHLNIO = kFGGENLKMEB;
				break;
			}
			case 34u:
			{
				LLANPOBDJIM lLANPOBDJIM = new LLANPOBDJIM();
				if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.LEFOIGFGJGJ)
				{
					lLANPOBDJIM.MergeFrom(LEFOIGFGJGJ);
				}
				input.ReadMessage(lLANPOBDJIM);
				LEFOIGFGJGJ = lLANPOBDJIM;
				break;
			}
			case 42u:
			{
				PFBKJICJGBI pFBKJICJGBI = new PFBKJICJGBI();
				if (bJHPPIKHFMFCase_ == BJHPPIKHFMFOneofCase.INFGAKANLPN)
				{
					pFBKJICJGBI.MergeFrom(INFGAKANLPN);
				}
				input.ReadMessage(pFBKJICJGBI);
				INFGAKANLPN = pFBKJICJGBI;
				break;
			}
			}
		}
	}
}
