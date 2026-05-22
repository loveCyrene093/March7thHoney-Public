using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueWorkbenchHandleFuncScRsp : IMessage<RogueWorkbenchHandleFuncScRsp>, IMessage, IEquatable<RogueWorkbenchHandleFuncScRsp>, IDeepCloneable<RogueWorkbenchHandleFuncScRsp>, IBufferMessage
{
	private static readonly MessageParser<RogueWorkbenchHandleFuncScRsp> _parser = new MessageParser<RogueWorkbenchHandleFuncScRsp>(() => new RogueWorkbenchHandleFuncScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 1;

	private uint retcode_;

	public const int FuncIdFieldNumber = 3;

	private uint funcId_;

	public const int ACADKPJKADEFieldNumber = 11;

	private CGKBEBCCDGF aCADKPJKADE_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueWorkbenchHandleFuncScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueWorkbenchHandleFuncScRspReflection.Descriptor.MessageTypes[0];

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
	public uint FuncId
	{
		get
		{
			return funcId_;
		}
		set
		{
			funcId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CGKBEBCCDGF ACADKPJKADE
	{
		get
		{
			return aCADKPJKADE_;
		}
		set
		{
			aCADKPJKADE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchHandleFuncScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchHandleFuncScRsp(RogueWorkbenchHandleFuncScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		funcId_ = other.funcId_;
		aCADKPJKADE_ = ((other.aCADKPJKADE_ != null) ? other.aCADKPJKADE_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueWorkbenchHandleFuncScRsp Clone()
	{
		return new RogueWorkbenchHandleFuncScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueWorkbenchHandleFuncScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueWorkbenchHandleFuncScRsp other)
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
		if (FuncId != other.FuncId)
		{
			return false;
		}
		if (!object.Equals(ACADKPJKADE, other.ACADKPJKADE))
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
		if (FuncId != 0)
		{
			num ^= FuncId.GetHashCode();
		}
		if (aCADKPJKADE_ != null)
		{
			num ^= ACADKPJKADE.GetHashCode();
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
		if (FuncId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(FuncId);
		}
		if (aCADKPJKADE_ != null)
		{
			output.WriteRawTag(90);
			output.WriteMessage(ACADKPJKADE);
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
		if (FuncId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(FuncId);
		}
		if (aCADKPJKADE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(ACADKPJKADE);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueWorkbenchHandleFuncScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.FuncId != 0)
		{
			FuncId = other.FuncId;
		}
		if (other.aCADKPJKADE_ != null)
		{
			if (aCADKPJKADE_ == null)
			{
				ACADKPJKADE = new CGKBEBCCDGF();
			}
			ACADKPJKADE.MergeFrom(other.ACADKPJKADE);
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
			case 24u:
				FuncId = input.ReadUInt32();
				break;
			case 90u:
				if (aCADKPJKADE_ == null)
				{
					ACADKPJKADE = new CGKBEBCCDGF();
				}
				input.ReadMessage(ACADKPJKADE);
				break;
			}
		}
	}
}
