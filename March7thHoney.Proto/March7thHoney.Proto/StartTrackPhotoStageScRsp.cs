using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class StartTrackPhotoStageScRsp : IMessage<StartTrackPhotoStageScRsp>, IMessage, IEquatable<StartTrackPhotoStageScRsp>, IDeepCloneable<StartTrackPhotoStageScRsp>, IBufferMessage
{
	private static readonly MessageParser<StartTrackPhotoStageScRsp> _parser = new MessageParser<StartTrackPhotoStageScRsp>(() => new StartTrackPhotoStageScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 10;

	private uint retcode_;

	public const int MDILDJMPNGHFieldNumber = 12;

	private uint mDILDJMPNGH_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<StartTrackPhotoStageScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => StartTrackPhotoStageScRspReflection.Descriptor.MessageTypes[0];

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
	public uint MDILDJMPNGH
	{
		get
		{
			return mDILDJMPNGH_;
		}
		set
		{
			mDILDJMPNGH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartTrackPhotoStageScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartTrackPhotoStageScRsp(StartTrackPhotoStageScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		mDILDJMPNGH_ = other.mDILDJMPNGH_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public StartTrackPhotoStageScRsp Clone()
	{
		return new StartTrackPhotoStageScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as StartTrackPhotoStageScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(StartTrackPhotoStageScRsp other)
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
		if (MDILDJMPNGH != other.MDILDJMPNGH)
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
		if (MDILDJMPNGH != 0)
		{
			num ^= MDILDJMPNGH.GetHashCode();
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
			output.WriteRawTag(80);
			output.WriteUInt32(Retcode);
		}
		if (MDILDJMPNGH != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(MDILDJMPNGH);
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
		if (MDILDJMPNGH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MDILDJMPNGH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(StartTrackPhotoStageScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.MDILDJMPNGH != 0)
			{
				MDILDJMPNGH = other.MDILDJMPNGH;
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
			case 80u:
				Retcode = input.ReadUInt32();
				break;
			case 96u:
				MDILDJMPNGH = input.ReadUInt32();
				break;
			}
		}
	}
}
