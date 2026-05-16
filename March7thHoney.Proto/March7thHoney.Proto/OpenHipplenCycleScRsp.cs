using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class OpenHipplenCycleScRsp : IMessage<OpenHipplenCycleScRsp>, IMessage, IEquatable<OpenHipplenCycleScRsp>, IDeepCloneable<OpenHipplenCycleScRsp>, IBufferMessage
{
	private static readonly MessageParser<OpenHipplenCycleScRsp> _parser = new MessageParser<OpenHipplenCycleScRsp>(() => new OpenHipplenCycleScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int ACJHGLGHEAHFieldNumber = 3;

	private OOLHNFNKOHN aCJHGLGHEAH_;

	public const int IPOEIGADLJNFieldNumber = 9;

	private uint iPOEIGADLJN_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OpenHipplenCycleScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => OpenHipplenCycleScRspReflection.Descriptor.MessageTypes[0];

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
	public OOLHNFNKOHN ACJHGLGHEAH
	{
		get
		{
			return aCJHGLGHEAH_;
		}
		set
		{
			aCJHGLGHEAH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IPOEIGADLJN
	{
		get
		{
			return iPOEIGADLJN_;
		}
		set
		{
			iPOEIGADLJN_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenHipplenCycleScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenHipplenCycleScRsp(OpenHipplenCycleScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		aCJHGLGHEAH_ = ((other.aCJHGLGHEAH_ != null) ? other.aCJHGLGHEAH_.Clone() : null);
		iPOEIGADLJN_ = other.iPOEIGADLJN_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OpenHipplenCycleScRsp Clone()
	{
		return new OpenHipplenCycleScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as OpenHipplenCycleScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OpenHipplenCycleScRsp other)
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
		if (!object.Equals(ACJHGLGHEAH, other.ACJHGLGHEAH))
		{
			return false;
		}
		if (IPOEIGADLJN != other.IPOEIGADLJN)
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
		if (aCJHGLGHEAH_ != null)
		{
			num ^= ACJHGLGHEAH.GetHashCode();
		}
		if (IPOEIGADLJN != 0)
		{
			num ^= IPOEIGADLJN.GetHashCode();
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
			output.WriteRawTag(8);
			output.WriteUInt32(Retcode);
		}
		if (aCJHGLGHEAH_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(ACJHGLGHEAH);
		}
		if (IPOEIGADLJN != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(IPOEIGADLJN);
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
		if (aCJHGLGHEAH_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ACJHGLGHEAH);
		}
		if (IPOEIGADLJN != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IPOEIGADLJN);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OpenHipplenCycleScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.aCJHGLGHEAH_ != null)
		{
			if (aCJHGLGHEAH_ == null)
			{
				ACJHGLGHEAH = new OOLHNFNKOHN();
			}
			ACJHGLGHEAH.MergeFrom(other.ACJHGLGHEAH);
		}
		if (other.IPOEIGADLJN != 0)
		{
			IPOEIGADLJN = other.IPOEIGADLJN;
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
			case 8u:
				Retcode = input.ReadUInt32();
				break;
			case 26u:
				if (aCJHGLGHEAH_ == null)
				{
					ACJHGLGHEAH = new OOLHNFNKOHN();
				}
				input.ReadMessage(ACJHGLGHEAH);
				break;
			case 72u:
				IPOEIGADLJN = input.ReadUInt32();
				break;
			}
		}
	}
}
