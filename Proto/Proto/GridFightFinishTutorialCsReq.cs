using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightFinishTutorialCsReq : IMessage<GridFightFinishTutorialCsReq>, IMessage, IEquatable<GridFightFinishTutorialCsReq>, IDeepCloneable<GridFightFinishTutorialCsReq>, IBufferMessage
{
	private static readonly MessageParser<GridFightFinishTutorialCsReq> _parser = new MessageParser<GridFightFinishTutorialCsReq>(() => new GridFightFinishTutorialCsReq());

	private UnknownFieldSet _unknownFields;

	public const int JMMLPCJAGLKFieldNumber = 4;

	private uint jMMLPCJAGLK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightFinishTutorialCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightFinishTutorialCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JMMLPCJAGLK
	{
		get
		{
			return jMMLPCJAGLK_;
		}
		set
		{
			jMMLPCJAGLK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishTutorialCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishTutorialCsReq(GridFightFinishTutorialCsReq other)
		: this()
	{
		jMMLPCJAGLK_ = other.jMMLPCJAGLK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightFinishTutorialCsReq Clone()
	{
		return new GridFightFinishTutorialCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightFinishTutorialCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightFinishTutorialCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JMMLPCJAGLK != other.JMMLPCJAGLK)
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
		if (JMMLPCJAGLK != 0)
		{
			num ^= JMMLPCJAGLK.GetHashCode();
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
		if (JMMLPCJAGLK != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(JMMLPCJAGLK);
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
		if (JMMLPCJAGLK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JMMLPCJAGLK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightFinishTutorialCsReq other)
	{
		if (other != null)
		{
			if (other.JMMLPCJAGLK != 0)
			{
				JMMLPCJAGLK = other.JMMLPCJAGLK;
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
			if (num != 32)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				JMMLPCJAGLK = input.ReadUInt32();
			}
		}
	}
}
