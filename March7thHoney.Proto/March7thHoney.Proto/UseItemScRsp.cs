using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UseItemScRsp : IMessage<UseItemScRsp>, IMessage, IEquatable<UseItemScRsp>, IDeepCloneable<UseItemScRsp>, IBufferMessage
{
	private static readonly MessageParser<UseItemScRsp> _parser = new MessageParser<UseItemScRsp>(() => new UseItemScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 3;

	private uint retcode_;

	public const int UseItemCountFieldNumber = 5;

	private uint useItemCount_;

	public const int ReturnDataFieldNumber = 6;

	private ItemList returnData_;

	public const int UseItemIdFieldNumber = 10;

	private uint useItemId_;

	public const int FormulaIdFieldNumber = 11;

	private uint formulaId_;

	public const int MonthCardOutDateTimeFieldNumber = 14;

	private ulong monthCardOutDateTime_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UseItemScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UseItemScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public uint UseItemCount
	{
		get
		{
			return useItemCount_;
		}
		set
		{
			useItemCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ItemList ReturnData
	{
		get
		{
			return returnData_;
		}
		set
		{
			returnData_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint UseItemId
	{
		get
		{
			return useItemId_;
		}
		set
		{
			useItemId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint FormulaId
	{
		get
		{
			return formulaId_;
		}
		set
		{
			formulaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong MonthCardOutDateTime
	{
		get
		{
			return monthCardOutDateTime_;
		}
		set
		{
			monthCardOutDateTime_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemScRsp(UseItemScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		useItemCount_ = other.useItemCount_;
		returnData_ = ((other.returnData_ != null) ? other.returnData_.Clone() : null);
		useItemId_ = other.useItemId_;
		formulaId_ = other.formulaId_;
		monthCardOutDateTime_ = other.monthCardOutDateTime_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UseItemScRsp Clone()
	{
		return new UseItemScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UseItemScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UseItemScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (UseItemCount != other.UseItemCount)
		{
			return false;
		}
		if (!object.Equals(ReturnData, other.ReturnData))
		{
			return false;
		}
		if (UseItemId != other.UseItemId)
		{
			return false;
		}
		if (FormulaId != other.FormulaId)
		{
			return false;
		}
		if (MonthCardOutDateTime != other.MonthCardOutDateTime)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (UseItemCount != 0)
		{
			num ^= UseItemCount.GetHashCode();
		}
		if (returnData_ != null)
		{
			num ^= ReturnData.GetHashCode();
		}
		if (UseItemId != 0)
		{
			num ^= UseItemId.GetHashCode();
		}
		if (FormulaId != 0)
		{
			num ^= FormulaId.GetHashCode();
		}
		if (MonthCardOutDateTime != 0L)
		{
			num ^= MonthCardOutDateTime.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(Retcode);
		}
		if (UseItemCount != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(UseItemCount);
		}
		if (returnData_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(ReturnData);
		}
		if (UseItemId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(UseItemId);
		}
		if (FormulaId != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(FormulaId);
		}
		if (MonthCardOutDateTime != 0L)
		{
			output.WriteRawTag(112);
			output.WriteUInt64(MonthCardOutDateTime);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (UseItemCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UseItemCount);
		}
		if (returnData_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ReturnData);
		}
		if (UseItemId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(UseItemId);
		}
		if (FormulaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FormulaId);
		}
		if (MonthCardOutDateTime != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(MonthCardOutDateTime);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UseItemScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.UseItemCount != 0)
		{
			UseItemCount = other.UseItemCount;
		}
		if (other.returnData_ != null)
		{
			if (returnData_ == null)
			{
				ReturnData = new ItemList();
			}
			ReturnData.MergeFrom(other.ReturnData);
		}
		if (other.UseItemId != 0)
		{
			UseItemId = other.UseItemId;
		}
		if (other.FormulaId != 0)
		{
			FormulaId = other.FormulaId;
		}
		if (other.MonthCardOutDateTime != 0L)
		{
			MonthCardOutDateTime = other.MonthCardOutDateTime;
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
				Retcode = input.ReadUInt32();
				break;
			case 40u:
				UseItemCount = input.ReadUInt32();
				break;
			case 50u:
				if (returnData_ == null)
				{
					ReturnData = new ItemList();
				}
				input.ReadMessage(ReturnData);
				break;
			case 80u:
				UseItemId = input.ReadUInt32();
				break;
			case 88u:
				FormulaId = input.ReadUInt32();
				break;
			case 112u:
				MonthCardOutDateTime = input.ReadUInt64();
				break;
			}
		}
	}
}
