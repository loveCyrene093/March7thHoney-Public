using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OGMDDDFDNJP : IMessage<OGMDDDFDNJP>, IMessage, IEquatable<OGMDDDFDNJP>, IDeepCloneable<OGMDDDFDNJP>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		Name = 3,
		RelicList = 8
	}

	private static readonly MessageParser<OGMDDDFDNJP> _parser = new MessageParser<OGMDDDFDNJP>(() => new OGMDDDFDNJP());

	private UnknownFieldSet _unknownFields;

	public const int UniqueIdFieldNumber = 4;

	private uint uniqueId_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int NameFieldNumber = 3;

	public const int RelicListFieldNumber = 8;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OGMDDDFDNJP> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OGMDDDFDNJPReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UniqueId
	{
		get
		{
			return uniqueId_;
		}
		set
		{
			uniqueId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		get
		{
			if (!HasName)
			{
				return "";
			}
			return (string)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = ProtoPreconditions.CheckNotNull(value, "value");
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.Name;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasName => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.Name;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DPDDLAOBMBH RelicList
	{
		get
		{
			if (bPIHFAJCLOCCase_ != BPIHFAJCLOCOneofCase.RelicList)
			{
				return null;
			}
			return (DPDDLAOBMBH)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = ((value != null) ? BPIHFAJCLOCOneofCase.RelicList : BPIHFAJCLOCOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGMDDDFDNJP()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGMDDDFDNJP(OGMDDDFDNJP other)
		: this()
	{
		uniqueId_ = other.uniqueId_;
		retcode_ = other.retcode_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
		case BPIHFAJCLOCOneofCase.RelicList:
			RelicList = other.RelicList.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OGMDDDFDNJP Clone()
	{
		return new OGMDDDFDNJP(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearName()
	{
		if (HasName)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OGMDDDFDNJP);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OGMDDDFDNJP other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (UniqueId != other.UniqueId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (Name != other.Name)
		{
			return false;
		}
		if (!object.Equals(RelicList, other.RelicList))
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (UniqueId != 0)
		{
			num ^= UniqueId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HasName)
		{
			num ^= Name.GetHashCode();
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
		{
			num ^= RelicList.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (HasName)
		{
			output.WriteRawTag(26);
			output.WriteString(Name);
		}
		if (UniqueId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(UniqueId);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
		{
			output.WriteRawTag(66);
			output.WriteMessage(RelicList);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
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
		if (UniqueId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UniqueId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HasName)
		{
			num += 1 + CodedOutputStream.ComputeStringSize(Name);
		}
		if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RelicList);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OGMDDDFDNJP other)
	{
		if (other == null)
		{
			return;
		}
		if (other.UniqueId != 0)
		{
			UniqueId = other.UniqueId;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.Name:
			Name = other.Name;
			break;
		case BPIHFAJCLOCOneofCase.RelicList:
			if (RelicList == null)
			{
				RelicList = new DPDDLAOBMBH();
			}
			RelicList.MergeFrom(other.RelicList);
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
			case 26u:
				Name = input.ReadString();
				break;
			case 32u:
				UniqueId = input.ReadUInt32();
				break;
			case 66u:
			{
				DPDDLAOBMBH dPDDLAOBMBH = new DPDDLAOBMBH();
				if (bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.RelicList)
				{
					dPDDLAOBMBH.MergeFrom(RelicList);
				}
				input.ReadMessage(dPDDLAOBMBH);
				RelicList = dPDDLAOBMBH;
				break;
			}
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
