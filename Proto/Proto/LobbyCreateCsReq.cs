using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LobbyCreateCsReq : IMessage<LobbyCreateCsReq>, IMessage, IEquatable<LobbyCreateCsReq>, IDeepCloneable<LobbyCreateCsReq>, IBufferMessage
{
	private static readonly MessageParser<LobbyCreateCsReq> _parser = new MessageParser<LobbyCreateCsReq>(() => new LobbyCreateCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JHCJMKDDNNFFieldNumber = 1;

	private LobbyGameExtInfo jHCJMKDDNNF_;

	public const int CHEODMKAHJMFieldNumber = 5;

	private uint cHEODMKAHJM_;

	public const int PLOBMBFPNFKFieldNumber = 12;

	private FightGameMode pLOBMBFPNFK_;

	public const int POFOCMIHJIAFieldNumber = 13;

	private PBICJCPDLGD pOFOCMIHJIA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LobbyCreateCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LobbyCreateCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyGameExtInfo JHCJMKDDNNF
	{
		get
		{
			return jHCJMKDDNNF_;
		}
		set
		{
			jHCJMKDDNNF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHEODMKAHJM
	{
		get
		{
			return cHEODMKAHJM_;
		}
		set
		{
			cHEODMKAHJM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightGameMode PLOBMBFPNFK
	{
		get
		{
			return pLOBMBFPNFK_;
		}
		set
		{
			pLOBMBFPNFK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBICJCPDLGD POFOCMIHJIA
	{
		get
		{
			return pOFOCMIHJIA_;
		}
		set
		{
			pOFOCMIHJIA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCreateCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCreateCsReq(LobbyCreateCsReq other)
		: this()
	{
		jHCJMKDDNNF_ = ((other.jHCJMKDDNNF_ != null) ? other.jHCJMKDDNNF_.Clone() : null);
		cHEODMKAHJM_ = other.cHEODMKAHJM_;
		pLOBMBFPNFK_ = other.pLOBMBFPNFK_;
		pOFOCMIHJIA_ = ((other.pOFOCMIHJIA_ != null) ? other.pOFOCMIHJIA_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LobbyCreateCsReq Clone()
	{
		return new LobbyCreateCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LobbyCreateCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LobbyCreateCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JHCJMKDDNNF, other.JHCJMKDDNNF))
		{
			return false;
		}
		if (CHEODMKAHJM != other.CHEODMKAHJM)
		{
			return false;
		}
		if (PLOBMBFPNFK != other.PLOBMBFPNFK)
		{
			return false;
		}
		if (!object.Equals(POFOCMIHJIA, other.POFOCMIHJIA))
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
		if (jHCJMKDDNNF_ != null)
		{
			num ^= JHCJMKDDNNF.GetHashCode();
		}
		if (CHEODMKAHJM != 0)
		{
			num ^= CHEODMKAHJM.GetHashCode();
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num ^= PLOBMBFPNFK.GetHashCode();
		}
		if (pOFOCMIHJIA_ != null)
		{
			num ^= POFOCMIHJIA.GetHashCode();
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
		if (jHCJMKDDNNF_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(JHCJMKDDNNF);
		}
		if (CHEODMKAHJM != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(CHEODMKAHJM);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			output.WriteRawTag(96);
			output.WriteEnum((int)PLOBMBFPNFK);
		}
		if (pOFOCMIHJIA_ != null)
		{
			output.WriteRawTag(106);
			output.WriteMessage(POFOCMIHJIA);
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
		if (jHCJMKDDNNF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JHCJMKDDNNF);
		}
		if (CHEODMKAHJM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHEODMKAHJM);
		}
		if (PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)PLOBMBFPNFK);
		}
		if (pOFOCMIHJIA_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(POFOCMIHJIA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LobbyCreateCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jHCJMKDDNNF_ != null)
		{
			if (jHCJMKDDNNF_ == null)
			{
				JHCJMKDDNNF = new LobbyGameExtInfo();
			}
			JHCJMKDDNNF.MergeFrom(other.JHCJMKDDNNF);
		}
		if (other.CHEODMKAHJM != 0)
		{
			CHEODMKAHJM = other.CHEODMKAHJM;
		}
		if (other.PLOBMBFPNFK != FightGameMode.EjimiogaoklPcpdhelpkem)
		{
			PLOBMBFPNFK = other.PLOBMBFPNFK;
		}
		if (other.pOFOCMIHJIA_ != null)
		{
			if (pOFOCMIHJIA_ == null)
			{
				POFOCMIHJIA = new PBICJCPDLGD();
			}
			POFOCMIHJIA.MergeFrom(other.POFOCMIHJIA);
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
				if (jHCJMKDDNNF_ == null)
				{
					JHCJMKDDNNF = new LobbyGameExtInfo();
				}
				input.ReadMessage(JHCJMKDDNNF);
				break;
			case 40u:
				CHEODMKAHJM = input.ReadUInt32();
				break;
			case 96u:
				PLOBMBFPNFK = (FightGameMode)input.ReadEnum();
				break;
			case 106u:
				if (pOFOCMIHJIA_ == null)
				{
					POFOCMIHJIA = new PBICJCPDLGD();
				}
				input.ReadMessage(POFOCMIHJIA);
				break;
			}
		}
	}
}
