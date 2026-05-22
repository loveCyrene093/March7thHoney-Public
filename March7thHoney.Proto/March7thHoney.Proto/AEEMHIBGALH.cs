using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class AEEMHIBGALH : IMessage<AEEMHIBGALH>, IMessage, IEquatable<AEEMHIBGALH>, IDeepCloneable<AEEMHIBGALH>, IBufferMessage
{
	private static readonly MessageParser<AEEMHIBGALH> _parser = new MessageParser<AEEMHIBGALH>(() => new AEEMHIBGALH());

	private UnknownFieldSet _unknownFields;

	public const int CostDataFieldNumber = 3;

	private ItemCostData costData_;

	public const int PIGDIFAKIGMFieldNumber = 6;

	private int pIGDIFAKIGM_;

	public const int JKIMLIPMKFHFieldNumber = 13;

	private uint jKIMLIPMKFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AEEMHIBGALH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => AEEMHIBGALHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData CostData
	{
		get
		{
			return costData_;
		}
		set
		{
			costData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PIGDIFAKIGM
	{
		get
		{
			return pIGDIFAKIGM_;
		}
		set
		{
			pIGDIFAKIGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JKIMLIPMKFH
	{
		get
		{
			return jKIMLIPMKFH_;
		}
		set
		{
			jKIMLIPMKFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEEMHIBGALH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEEMHIBGALH(AEEMHIBGALH other)
		: this()
	{
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		pIGDIFAKIGM_ = other.pIGDIFAKIGM_;
		jKIMLIPMKFH_ = other.jKIMLIPMKFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AEEMHIBGALH Clone()
	{
		return new AEEMHIBGALH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as AEEMHIBGALH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AEEMHIBGALH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (PIGDIFAKIGM != other.PIGDIFAKIGM)
		{
			return false;
		}
		if (JKIMLIPMKFH != other.JKIMLIPMKFH)
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
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (PIGDIFAKIGM != 0)
		{
			num ^= PIGDIFAKIGM.GetHashCode();
		}
		if (JKIMLIPMKFH != 0)
		{
			num ^= JKIMLIPMKFH.GetHashCode();
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
		if (costData_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(CostData);
		}
		if (PIGDIFAKIGM != 0)
		{
			output.WriteRawTag(48);
			output.WriteInt32(PIGDIFAKIGM);
		}
		if (JKIMLIPMKFH != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(JKIMLIPMKFH);
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
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (PIGDIFAKIGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PIGDIFAKIGM);
		}
		if (JKIMLIPMKFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JKIMLIPMKFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AEEMHIBGALH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.PIGDIFAKIGM != 0)
		{
			PIGDIFAKIGM = other.PIGDIFAKIGM;
		}
		if (other.JKIMLIPMKFH != 0)
		{
			JKIMLIPMKFH = other.JKIMLIPMKFH;
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
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 48u:
				PIGDIFAKIGM = input.ReadInt32();
				break;
			case 104u:
				JKIMLIPMKFH = input.ReadUInt32();
				break;
			}
		}
	}
}
