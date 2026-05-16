using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PBICJCPDLGD : IMessage<PBICJCPDLGD>, IMessage, IEquatable<PBICJCPDLGD>, IDeepCloneable<PBICJCPDLGD>, IBufferMessage
{
	public enum BGMDKLOBICMOneofCase
	{
		None = 0,
		LobbyGridFightInfo = 1001,
		PCFNJJCOJED = 1002,
		LKICHFPCOBO = 1003
	}

	private static readonly MessageParser<PBICJCPDLGD> _parser = new MessageParser<PBICJCPDLGD>(() => new PBICJCPDLGD());

	private UnknownFieldSet _unknownFields;

	public const int LobbyGridFightInfoFieldNumber = 1001;

	public const int PCFNJJCOJEDFieldNumber = 1002;

	public const int LKICHFPCOBOFieldNumber = 1003;

	private object bGMDKLOBICM_;

	private BGMDKLOBICMOneofCase bGMDKLOBICMCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PBICJCPDLGD> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PBICJCPDLGDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DFLDACOIHKJ LobbyGridFightInfo
	{
		get
		{
			if (bGMDKLOBICMCase_ != BGMDKLOBICMOneofCase.LobbyGridFightInfo)
			{
				return null;
			}
			return (DFLDACOIHKJ)bGMDKLOBICM_;
		}
		set
		{
			bGMDKLOBICM_ = value;
			bGMDKLOBICMCase_ = ((value != null) ? BGMDKLOBICMOneofCase.LobbyGridFightInfo : BGMDKLOBICMOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IDNPIHFOOAL PCFNJJCOJED
	{
		get
		{
			if (bGMDKLOBICMCase_ != BGMDKLOBICMOneofCase.PCFNJJCOJED)
			{
				return null;
			}
			return (IDNPIHFOOAL)bGMDKLOBICM_;
		}
		set
		{
			bGMDKLOBICM_ = value;
			bGMDKLOBICMCase_ = ((value != null) ? BGMDKLOBICMOneofCase.PCFNJJCOJED : BGMDKLOBICMOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NDBDDEAPIDP LKICHFPCOBO
	{
		get
		{
			if (bGMDKLOBICMCase_ != BGMDKLOBICMOneofCase.LKICHFPCOBO)
			{
				return null;
			}
			return (NDBDDEAPIDP)bGMDKLOBICM_;
		}
		set
		{
			bGMDKLOBICM_ = value;
			bGMDKLOBICMCase_ = ((value != null) ? BGMDKLOBICMOneofCase.LKICHFPCOBO : BGMDKLOBICMOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGMDKLOBICMOneofCase BGMDKLOBICMCase => bGMDKLOBICMCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBICJCPDLGD()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBICJCPDLGD(PBICJCPDLGD other)
		: this()
	{
		switch (other.BGMDKLOBICMCase)
		{
		case BGMDKLOBICMOneofCase.LobbyGridFightInfo:
			LobbyGridFightInfo = other.LobbyGridFightInfo.Clone();
			break;
		case BGMDKLOBICMOneofCase.PCFNJJCOJED:
			PCFNJJCOJED = other.PCFNJJCOJED.Clone();
			break;
		case BGMDKLOBICMOneofCase.LKICHFPCOBO:
			LKICHFPCOBO = other.LKICHFPCOBO.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PBICJCPDLGD Clone()
	{
		return new PBICJCPDLGD(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBGMDKLOBICM()
	{
		bGMDKLOBICMCase_ = BGMDKLOBICMOneofCase.None;
		bGMDKLOBICM_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PBICJCPDLGD);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PBICJCPDLGD other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(LobbyGridFightInfo, other.LobbyGridFightInfo))
		{
			return false;
		}
		if (!object.Equals(PCFNJJCOJED, other.PCFNJJCOJED))
		{
			return false;
		}
		if (!object.Equals(LKICHFPCOBO, other.LKICHFPCOBO))
		{
			return false;
		}
		if (BGMDKLOBICMCase != other.BGMDKLOBICMCase)
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
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LobbyGridFightInfo)
		{
			num ^= LobbyGridFightInfo.GetHashCode();
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.PCFNJJCOJED)
		{
			num ^= PCFNJJCOJED.GetHashCode();
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LKICHFPCOBO)
		{
			num ^= LKICHFPCOBO.GetHashCode();
		}
		num ^= (int)bGMDKLOBICMCase_;
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
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LobbyGridFightInfo)
		{
			output.WriteRawTag(202, 62);
			output.WriteMessage(LobbyGridFightInfo);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.PCFNJJCOJED)
		{
			output.WriteRawTag(210, 62);
			output.WriteMessage(PCFNJJCOJED);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LKICHFPCOBO)
		{
			output.WriteRawTag(218, 62);
			output.WriteMessage(LKICHFPCOBO);
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
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LobbyGridFightInfo)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LobbyGridFightInfo);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.PCFNJJCOJED)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(PCFNJJCOJED);
		}
		if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LKICHFPCOBO)
		{
			num += 2 + CodedOutputStream.ComputeMessageSize(LKICHFPCOBO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PBICJCPDLGD other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.BGMDKLOBICMCase)
		{
		case BGMDKLOBICMOneofCase.LobbyGridFightInfo:
			if (LobbyGridFightInfo == null)
			{
				LobbyGridFightInfo = new DFLDACOIHKJ();
			}
			LobbyGridFightInfo.MergeFrom(other.LobbyGridFightInfo);
			break;
		case BGMDKLOBICMOneofCase.PCFNJJCOJED:
			if (PCFNJJCOJED == null)
			{
				PCFNJJCOJED = new IDNPIHFOOAL();
			}
			PCFNJJCOJED.MergeFrom(other.PCFNJJCOJED);
			break;
		case BGMDKLOBICMOneofCase.LKICHFPCOBO:
			if (LKICHFPCOBO == null)
			{
				LKICHFPCOBO = new NDBDDEAPIDP();
			}
			LKICHFPCOBO.MergeFrom(other.LKICHFPCOBO);
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
			case 8010u:
			{
				DFLDACOIHKJ dFLDACOIHKJ = new DFLDACOIHKJ();
				if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LobbyGridFightInfo)
				{
					dFLDACOIHKJ.MergeFrom(LobbyGridFightInfo);
				}
				input.ReadMessage(dFLDACOIHKJ);
				LobbyGridFightInfo = dFLDACOIHKJ;
				break;
			}
			case 8018u:
			{
				IDNPIHFOOAL iDNPIHFOOAL = new IDNPIHFOOAL();
				if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.PCFNJJCOJED)
				{
					iDNPIHFOOAL.MergeFrom(PCFNJJCOJED);
				}
				input.ReadMessage(iDNPIHFOOAL);
				PCFNJJCOJED = iDNPIHFOOAL;
				break;
			}
			case 8026u:
			{
				NDBDDEAPIDP nDBDDEAPIDP = new NDBDDEAPIDP();
				if (bGMDKLOBICMCase_ == BGMDKLOBICMOneofCase.LKICHFPCOBO)
				{
					nDBDDEAPIDP.MergeFrom(LKICHFPCOBO);
				}
				input.ReadMessage(nDBDDEAPIDP);
				LKICHFPCOBO = nDBDDEAPIDP;
				break;
			}
			}
		}
	}
}
