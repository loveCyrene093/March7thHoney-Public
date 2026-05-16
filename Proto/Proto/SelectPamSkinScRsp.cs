using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SelectPamSkinScRsp : IMessage<SelectPamSkinScRsp>, IMessage, IEquatable<SelectPamSkinScRsp>, IDeepCloneable<SelectPamSkinScRsp>, IBufferMessage
{
	private static readonly MessageParser<SelectPamSkinScRsp> _parser = new MessageParser<SelectPamSkinScRsp>(() => new SelectPamSkinScRsp());

	private UnknownFieldSet _unknownFields;

	public const int CurSkinFieldNumber = 4;

	private uint curSkin_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	public const int SetSkinFieldNumber = 15;

	private uint setSkin_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SelectPamSkinScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SelectPamSkinScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CurSkin
	{
		get
		{
			return curSkin_;
		}
		set
		{
			curSkin_ = value;
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
	public uint SetSkin
	{
		get
		{
			return setSkin_;
		}
		set
		{
			setSkin_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPamSkinScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPamSkinScRsp(SelectPamSkinScRsp other)
		: this()
	{
		curSkin_ = other.curSkin_;
		retcode_ = other.retcode_;
		setSkin_ = other.setSkin_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SelectPamSkinScRsp Clone()
	{
		return new SelectPamSkinScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SelectPamSkinScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SelectPamSkinScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CurSkin != other.CurSkin)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (SetSkin != other.SetSkin)
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
		if (CurSkin != 0)
		{
			num ^= CurSkin.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (SetSkin != 0)
		{
			num ^= SetSkin.GetHashCode();
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
		if (CurSkin != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(CurSkin);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(Retcode);
		}
		if (SetSkin != 0)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(SetSkin);
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
		if (CurSkin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CurSkin);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (SetSkin != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(SetSkin);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SelectPamSkinScRsp other)
	{
		if (other != null)
		{
			if (other.CurSkin != 0)
			{
				CurSkin = other.CurSkin;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.SetSkin != 0)
			{
				SetSkin = other.SetSkin;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 32u:
				CurSkin = input.ReadUInt32();
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			case 120u:
				SetSkin = input.ReadUInt32();
				break;
			}
		}
	}
}
