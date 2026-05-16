using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BAIKMOMEJMB : IMessage<BAIKMOMEJMB>, IMessage, IEquatable<BAIKMOMEJMB>, IDeepCloneable<BAIKMOMEJMB>, IBufferMessage
{
	private static readonly MessageParser<BAIKMOMEJMB> _parser = new MessageParser<BAIKMOMEJMB>(() => new BAIKMOMEJMB());

	private UnknownFieldSet _unknownFields;

	public const int EIENKJFFFJGFieldNumber = 9;

	private ILLBNKFBNBP eIENKJFFFJG_;

	public const int CostDataFieldNumber = 11;

	private ItemCostData costData_;

	public const int KLNHLEJKDMLFieldNumber = 13;

	private bool kLNHLEJKDML_;

	public const int EKKIAHNMDHMFieldNumber = 14;

	private ItemCostData eKKIAHNMDHM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BAIKMOMEJMB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BAIKMOMEJMBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ILLBNKFBNBP EIENKJFFFJG
	{
		get
		{
			return eIENKJFFFJG_;
		}
		set
		{
			eIENKJFFFJG_ = value;
		}
	}

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
	public bool KLNHLEJKDML
	{
		get
		{
			return kLNHLEJKDML_;
		}
		set
		{
			kLNHLEJKDML_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemCostData EKKIAHNMDHM
	{
		get
		{
			return eKKIAHNMDHM_;
		}
		set
		{
			eKKIAHNMDHM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAIKMOMEJMB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAIKMOMEJMB(BAIKMOMEJMB other)
		: this()
	{
		eIENKJFFFJG_ = ((other.eIENKJFFFJG_ != null) ? other.eIENKJFFFJG_.Clone() : null);
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		kLNHLEJKDML_ = other.kLNHLEJKDML_;
		eKKIAHNMDHM_ = ((other.eKKIAHNMDHM_ != null) ? other.eKKIAHNMDHM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BAIKMOMEJMB Clone()
	{
		return new BAIKMOMEJMB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BAIKMOMEJMB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BAIKMOMEJMB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(EIENKJFFFJG, other.EIENKJFFFJG))
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (KLNHLEJKDML != other.KLNHLEJKDML)
		{
			return false;
		}
		if (!object.Equals(EKKIAHNMDHM, other.EKKIAHNMDHM))
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
		if (eIENKJFFFJG_ != null)
		{
			num ^= EIENKJFFFJG.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (KLNHLEJKDML)
		{
			num ^= KLNHLEJKDML.GetHashCode();
		}
		if (eKKIAHNMDHM_ != null)
		{
			num ^= EKKIAHNMDHM.GetHashCode();
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
		if (eIENKJFFFJG_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(EIENKJFFFJG);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(CostData);
		}
		if (KLNHLEJKDML)
		{
			output.WriteRawTag(104);
			output.WriteBool(KLNHLEJKDML);
		}
		if (eKKIAHNMDHM_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(EKKIAHNMDHM);
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
		if (eIENKJFFFJG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EIENKJFFFJG);
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (KLNHLEJKDML)
		{
			num += 2;
		}
		if (eKKIAHNMDHM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EKKIAHNMDHM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BAIKMOMEJMB other)
	{
		if (other == null)
		{
			return;
		}
		if (other.eIENKJFFFJG_ != null)
		{
			if (eIENKJFFFJG_ == null)
			{
				EIENKJFFFJG = new ILLBNKFBNBP();
			}
			EIENKJFFFJG.MergeFrom(other.EIENKJFFFJG);
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.KLNHLEJKDML)
		{
			KLNHLEJKDML = other.KLNHLEJKDML;
		}
		if (other.eKKIAHNMDHM_ != null)
		{
			if (eKKIAHNMDHM_ == null)
			{
				EKKIAHNMDHM = new ItemCostData();
			}
			EKKIAHNMDHM.MergeFrom(other.EKKIAHNMDHM);
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
			case 74u:
				if (eIENKJFFFJG_ == null)
				{
					EIENKJFFFJG = new ILLBNKFBNBP();
				}
				input.ReadMessage(EIENKJFFFJG);
				break;
			case 90u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 104u:
				KLNHLEJKDML = input.ReadBool();
				break;
			case 114u:
				if (eKKIAHNMDHM_ == null)
				{
					EKKIAHNMDHM = new ItemCostData();
				}
				input.ReadMessage(EKKIAHNMDHM);
				break;
			}
		}
	}
}
