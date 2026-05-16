using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ResetEraFlipperDataScRsp : IMessage<ResetEraFlipperDataScRsp>, IMessage, IEquatable<ResetEraFlipperDataScRsp>, IDeepCloneable<ResetEraFlipperDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<ResetEraFlipperDataScRsp> _parser = new MessageParser<ResetEraFlipperDataScRsp>(() => new ResetEraFlipperDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DataFieldNumber = 4;

	private EraFlipperDataList data_;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int OIPLJJIODILFieldNumber = 13;

	private bool oIPLJJIODIL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ResetEraFlipperDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ResetEraFlipperDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EraFlipperDataList Data
	{
		get
		{
			return data_;
		}
		set
		{
			data_ = value;
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
	public bool OIPLJJIODIL
	{
		get
		{
			return oIPLJJIODIL_;
		}
		set
		{
			oIPLJJIODIL_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetEraFlipperDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetEraFlipperDataScRsp(ResetEraFlipperDataScRsp other)
		: this()
	{
		data_ = ((other.data_ != null) ? other.data_.Clone() : null);
		retcode_ = other.retcode_;
		oIPLJJIODIL_ = other.oIPLJJIODIL_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ResetEraFlipperDataScRsp Clone()
	{
		return new ResetEraFlipperDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ResetEraFlipperDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ResetEraFlipperDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(Data, other.Data))
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (OIPLJJIODIL != other.OIPLJJIODIL)
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
		if (data_ != null)
		{
			num ^= Data.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (OIPLJJIODIL)
		{
			num ^= OIPLJJIODIL.GetHashCode();
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
		if (data_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(Data);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (OIPLJJIODIL)
		{
			output.WriteRawTag(104);
			output.WriteBool(OIPLJJIODIL);
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
		if (data_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(Data);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (OIPLJJIODIL)
		{
			num += 2;
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ResetEraFlipperDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.data_ != null)
		{
			if (data_ == null)
			{
				Data = new EraFlipperDataList();
			}
			Data.MergeFrom(other.Data);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.OIPLJJIODIL)
		{
			OIPLJJIODIL = other.OIPLJJIODIL;
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
			case 34u:
				if (data_ == null)
				{
					Data = new EraFlipperDataList();
				}
				input.ReadMessage(Data);
				break;
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				OIPLJJIODIL = input.ReadBool();
				break;
			}
		}
	}
}
