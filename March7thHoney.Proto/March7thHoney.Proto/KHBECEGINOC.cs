using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KHBECEGINOC : IMessage<KHBECEGINOC>, IMessage, IEquatable<KHBECEGINOC>, IDeepCloneable<KHBECEGINOC>, IBufferMessage
{
	private static readonly MessageParser<KHBECEGINOC> _parser = new MessageParser<KHBECEGINOC>(() => new KHBECEGINOC());

	private UnknownFieldSet _unknownFields;

	public const int PIGDIFAKIGMFieldNumber = 3;

	private int pIGDIFAKIGM_;

	public const int CostDataFieldNumber = 5;

	private ItemCostData costData_;

	public const int DIDLKELKEPGFieldNumber = 9;

	private bool dIDLKELKEPG_;

	public const int MCKAGFGLACMFieldNumber = 14;

	private uint mCKAGFGLACM_;

	public const int JKIMLIPMKFHFieldNumber = 15;

	private uint jKIMLIPMKFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KHBECEGINOC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KHBECEGINOCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public bool DIDLKELKEPG
	{
		get
		{
			return dIDLKELKEPG_;
		}
		set
		{
			dIDLKELKEPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MCKAGFGLACM
	{
		get
		{
			return mCKAGFGLACM_;
		}
		set
		{
			mCKAGFGLACM_ = value;
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
	public KHBECEGINOC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHBECEGINOC(KHBECEGINOC other)
		: this()
	{
		pIGDIFAKIGM_ = other.pIGDIFAKIGM_;
		costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
		dIDLKELKEPG_ = other.dIDLKELKEPG_;
		mCKAGFGLACM_ = other.mCKAGFGLACM_;
		jKIMLIPMKFH_ = other.jKIMLIPMKFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KHBECEGINOC Clone()
	{
		return new KHBECEGINOC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KHBECEGINOC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KHBECEGINOC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PIGDIFAKIGM != other.PIGDIFAKIGM)
		{
			return false;
		}
		if (!object.Equals(CostData, other.CostData))
		{
			return false;
		}
		if (DIDLKELKEPG != other.DIDLKELKEPG)
		{
			return false;
		}
		if (MCKAGFGLACM != other.MCKAGFGLACM)
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
		if (PIGDIFAKIGM != 0)
		{
			num ^= PIGDIFAKIGM.GetHashCode();
		}
		if (costData_ != null)
		{
			num ^= CostData.GetHashCode();
		}
		if (DIDLKELKEPG)
		{
			num ^= DIDLKELKEPG.GetHashCode();
		}
		if (MCKAGFGLACM != 0)
		{
			num ^= MCKAGFGLACM.GetHashCode();
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
		if (PIGDIFAKIGM != 0)
		{
			output.WriteRawTag(24);
			output.WriteInt32(PIGDIFAKIGM);
		}
		if (costData_ != null)
		{
			output.WriteRawTag(42);
			output.WriteMessage(CostData);
		}
		if (DIDLKELKEPG)
		{
			output.WriteRawTag(72);
			output.WriteBool(DIDLKELKEPG);
		}
		if (MCKAGFGLACM != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(MCKAGFGLACM);
		}
		if (JKIMLIPMKFH != 0)
		{
			output.WriteRawTag(120);
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
		if (PIGDIFAKIGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeInt32Size(PIGDIFAKIGM);
		}
		if (costData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(CostData);
		}
		if (DIDLKELKEPG)
		{
			num += 2;
		}
		if (MCKAGFGLACM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MCKAGFGLACM);
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
	public void MergeFrom(KHBECEGINOC other)
	{
		if (other == null)
		{
			return;
		}
		if (other.PIGDIFAKIGM != 0)
		{
			PIGDIFAKIGM = other.PIGDIFAKIGM;
		}
		if (other.costData_ != null)
		{
			if (costData_ == null)
			{
				CostData = new ItemCostData();
			}
			CostData.MergeFrom(other.CostData);
		}
		if (other.DIDLKELKEPG)
		{
			DIDLKELKEPG = other.DIDLKELKEPG;
		}
		if (other.MCKAGFGLACM != 0)
		{
			MCKAGFGLACM = other.MCKAGFGLACM;
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
			case 24u:
				PIGDIFAKIGM = input.ReadInt32();
				break;
			case 42u:
				if (costData_ == null)
				{
					CostData = new ItemCostData();
				}
				input.ReadMessage(CostData);
				break;
			case 72u:
				DIDLKELKEPG = input.ReadBool();
				break;
			case 112u:
				MCKAGFGLACM = input.ReadUInt32();
				break;
			case 120u:
				JKIMLIPMKFH = input.ReadUInt32();
				break;
			}
		}
	}
}
