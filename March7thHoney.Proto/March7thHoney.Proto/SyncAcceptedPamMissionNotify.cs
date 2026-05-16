using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SyncAcceptedPamMissionNotify : IMessage<SyncAcceptedPamMissionNotify>, IMessage, IEquatable<SyncAcceptedPamMissionNotify>, IDeepCloneable<SyncAcceptedPamMissionNotify>, IBufferMessage
{
	private static readonly MessageParser<SyncAcceptedPamMissionNotify> _parser = new MessageParser<SyncAcceptedPamMissionNotify>(() => new SyncAcceptedPamMissionNotify());

	private UnknownFieldSet _unknownFields;

	public const int MainMissionIdFieldNumber = 4;

	private uint mainMissionId_;

	public const int NJMONGKLJJCFieldNumber = 6;

	private ulong nJMONGKLJJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SyncAcceptedPamMissionNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SyncAcceptedPamMissionNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MainMissionId
	{
		get
		{
			return mainMissionId_;
		}
		set
		{
			mainMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong NJMONGKLJJC
	{
		get
		{
			return nJMONGKLJJC_;
		}
		set
		{
			nJMONGKLJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncAcceptedPamMissionNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncAcceptedPamMissionNotify(SyncAcceptedPamMissionNotify other)
		: this()
	{
		mainMissionId_ = other.mainMissionId_;
		nJMONGKLJJC_ = other.nJMONGKLJJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SyncAcceptedPamMissionNotify Clone()
	{
		return new SyncAcceptedPamMissionNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SyncAcceptedPamMissionNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SyncAcceptedPamMissionNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (MainMissionId != other.MainMissionId)
		{
			return false;
		}
		if (NJMONGKLJJC != other.NJMONGKLJJC)
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
		if (MainMissionId != 0)
		{
			num ^= MainMissionId.GetHashCode();
		}
		if (NJMONGKLJJC != 0L)
		{
			num ^= NJMONGKLJJC.GetHashCode();
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
		if (MainMissionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(MainMissionId);
		}
		if (NJMONGKLJJC != 0L)
		{
			output.WriteRawTag(48);
			output.WriteUInt64(NJMONGKLJJC);
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
		if (MainMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MainMissionId);
		}
		if (NJMONGKLJJC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(NJMONGKLJJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SyncAcceptedPamMissionNotify other)
	{
		if (other != null)
		{
			if (other.MainMissionId != 0)
			{
				MainMissionId = other.MainMissionId;
			}
			if (other.NJMONGKLJJC != 0L)
			{
				NJMONGKLJJC = other.NJMONGKLJJC;
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
				MainMissionId = input.ReadUInt32();
				break;
			case 48u:
				NJMONGKLJJC = input.ReadUInt64();
				break;
			}
		}
	}
}
