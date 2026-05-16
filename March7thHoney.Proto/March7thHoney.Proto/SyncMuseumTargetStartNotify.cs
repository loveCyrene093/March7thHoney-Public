using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncMuseumTargetStartNotify : IMessage<SyncMuseumTargetStartNotify>, IMessage, IEquatable<SyncMuseumTargetStartNotify>, IDeepCloneable<SyncMuseumTargetStartNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncMuseumTargetStartNotify> _parser = new MessageParser<SyncMuseumTargetStartNotify>(() => new SyncMuseumTargetStartNotify());

	private UnknownFieldSet _unknownFields;

	public const int LPAGKHGCCFHFieldNumber = 14;

	private uint lPAGKHGCCFH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncMuseumTargetStartNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncMuseumTargetStartNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LPAGKHGCCFH
	{
		get
		{
			return lPAGKHGCCFH_;
		}
		set
		{
			lPAGKHGCCFH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetStartNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetStartNotify(SyncMuseumTargetStartNotify other)
		: this()
	{
		lPAGKHGCCFH_ = other.lPAGKHGCCFH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncMuseumTargetStartNotify Clone()
	{
		return new SyncMuseumTargetStartNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncMuseumTargetStartNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncMuseumTargetStartNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (LPAGKHGCCFH != other.LPAGKHGCCFH)
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
		if (LPAGKHGCCFH != 0)
		{
			num ^= LPAGKHGCCFH.GetHashCode();
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
		if (LPAGKHGCCFH != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(LPAGKHGCCFH);
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
		if (LPAGKHGCCFH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LPAGKHGCCFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncMuseumTargetStartNotify other)
	{
		if (other != null)
		{
			if (other.LPAGKHGCCFH != 0)
			{
				LPAGKHGCCFH = other.LPAGKHGCCFH;
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
			if (num != 112)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				LPAGKHGCCFH = input.ReadUInt32();
			}
		}
	}
}
