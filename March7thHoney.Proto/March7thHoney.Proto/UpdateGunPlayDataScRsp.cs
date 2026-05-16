using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateGunPlayDataScRsp : IMessage<UpdateGunPlayDataScRsp>, IMessage, IEquatable<UpdateGunPlayDataScRsp>, IDeepCloneable<UpdateGunPlayDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<UpdateGunPlayDataScRsp> _parser = new MessageParser<UpdateGunPlayDataScRsp>(() => new UpdateGunPlayDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DIFLKHMKHBGFieldNumber = 1;

	private DEOMNEOMPFE dIFLKHMKHBG_;

	public const int RetcodeFieldNumber = 5;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateGunPlayDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateGunPlayDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DEOMNEOMPFE DIFLKHMKHBG
	{
		get
		{
			return dIFLKHMKHBG_;
		}
		set
		{
			dIFLKHMKHBG_ = value;
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
	public UpdateGunPlayDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGunPlayDataScRsp(UpdateGunPlayDataScRsp other)
		: this()
	{
		dIFLKHMKHBG_ = ((other.dIFLKHMKHBG_ != null) ? other.dIFLKHMKHBG_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateGunPlayDataScRsp Clone()
	{
		return new UpdateGunPlayDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateGunPlayDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateGunPlayDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DIFLKHMKHBG, other.DIFLKHMKHBG))
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
		if (dIFLKHMKHBG_ != null)
		{
			num ^= DIFLKHMKHBG.GetHashCode();
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
		if (dIFLKHMKHBG_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DIFLKHMKHBG);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(40);
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
		if (dIFLKHMKHBG_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DIFLKHMKHBG);
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
	public void MergeFrom(UpdateGunPlayDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dIFLKHMKHBG_ != null)
		{
			if (dIFLKHMKHBG_ == null)
			{
				DIFLKHMKHBG = new DEOMNEOMPFE();
			}
			DIFLKHMKHBG.MergeFrom(other.DIFLKHMKHBG);
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
			case 10u:
				if (dIFLKHMKHBG_ == null)
				{
					DIFLKHMKHBG = new DEOMNEOMPFE();
				}
				input.ReadMessage(DIFLKHMKHBG);
				break;
			case 40u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
