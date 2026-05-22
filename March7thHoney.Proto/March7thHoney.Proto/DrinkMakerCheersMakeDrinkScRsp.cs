using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DrinkMakerCheersMakeDrinkScRsp : IMessage<DrinkMakerCheersMakeDrinkScRsp>, IMessage, IEquatable<DrinkMakerCheersMakeDrinkScRsp>, IDeepCloneable<DrinkMakerCheersMakeDrinkScRsp>, IBufferMessage
{
	private static readonly MessageParser<DrinkMakerCheersMakeDrinkScRsp> _parser = new MessageParser<DrinkMakerCheersMakeDrinkScRsp>(() => new DrinkMakerCheersMakeDrinkScRsp());

	private UnknownFieldSet _unknownFields;

	public const int JONJPMLHPDOFieldNumber = 3;

	private NCIFDEHCMBK jONJPMLHPDO_;

	public const int RetcodeFieldNumber = 7;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DrinkMakerCheersMakeDrinkScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DrinkMakerCheersMakeDrinkScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NCIFDEHCMBK JONJPMLHPDO
	{
		get
		{
			return jONJPMLHPDO_;
		}
		set
		{
			jONJPMLHPDO_ = value;
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
	public DrinkMakerCheersMakeDrinkScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersMakeDrinkScRsp(DrinkMakerCheersMakeDrinkScRsp other)
		: this()
	{
		jONJPMLHPDO_ = ((other.jONJPMLHPDO_ != null) ? other.jONJPMLHPDO_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DrinkMakerCheersMakeDrinkScRsp Clone()
	{
		return new DrinkMakerCheersMakeDrinkScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DrinkMakerCheersMakeDrinkScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DrinkMakerCheersMakeDrinkScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(JONJPMLHPDO, other.JONJPMLHPDO))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (jONJPMLHPDO_ != null)
		{
			num ^= JONJPMLHPDO.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (jONJPMLHPDO_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(JONJPMLHPDO);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(56);
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
		if (jONJPMLHPDO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(JONJPMLHPDO);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DrinkMakerCheersMakeDrinkScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.jONJPMLHPDO_ != null)
		{
			if (jONJPMLHPDO_ == null)
			{
				JONJPMLHPDO = new NCIFDEHCMBK();
			}
			JONJPMLHPDO.MergeFrom(other.JONJPMLHPDO);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
				if (jONJPMLHPDO_ == null)
				{
					JONJPMLHPDO = new NCIFDEHCMBK();
				}
				input.ReadMessage(JONJPMLHPDO);
				break;
			case 56u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
