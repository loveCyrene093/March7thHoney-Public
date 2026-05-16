using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class EOBHKMGJGPG : IMessage<EOBHKMGJGPG>, IMessage, IEquatable<EOBHKMGJGPG>, IDeepCloneable<EOBHKMGJGPG>, IBufferMessage
{
	private static readonly MessageParser<EOBHKMGJGPG> _parser = new MessageParser<EOBHKMGJGPG>(() => new EOBHKMGJGPG());

	private UnknownFieldSet _unknownFields;

	public const int ABGLNIDOADMFieldNumber = 13;

	private uint aBGLNIDOADM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EOBHKMGJGPG> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => EOBHKMGJGPGReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABGLNIDOADM
	{
		get
		{
			return aBGLNIDOADM_;
		}
		set
		{
			aBGLNIDOADM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOBHKMGJGPG()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOBHKMGJGPG(EOBHKMGJGPG other)
		: this()
	{
		aBGLNIDOADM_ = other.aBGLNIDOADM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EOBHKMGJGPG Clone()
	{
		return new EOBHKMGJGPG(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as EOBHKMGJGPG);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(EOBHKMGJGPG other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (ABGLNIDOADM != other.ABGLNIDOADM)
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
		if (ABGLNIDOADM != 0)
		{
			num ^= ABGLNIDOADM.GetHashCode();
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
		if (ABGLNIDOADM != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(ABGLNIDOADM);
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
		if (ABGLNIDOADM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABGLNIDOADM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(EOBHKMGJGPG other)
	{
		if (other != null)
		{
			if (other.ABGLNIDOADM != 0)
			{
				ABGLNIDOADM = other.ABGLNIDOADM;
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
			if (num != 104)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				ABGLNIDOADM = input.ReadUInt32();
			}
		}
	}
}
